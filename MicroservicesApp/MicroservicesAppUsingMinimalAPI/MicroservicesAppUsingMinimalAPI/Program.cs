using MicroservicesAppUsingMinimalAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddTransient<DataSeeder>();

//Add Repository Pattern
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddDbContext<EmployeeDbContext>(x => x.UseSqlServer(connectionString));

//Add Swagger Support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwaggerUI();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

//Seed Data
void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeder>();
        service.Seed();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger(x => x.SerializeAsV2 = true);

app.MapGet("/", () => "Hello! Wanna see Employee details? If 'Yes' change the url.");

app.MapGet("/employee/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetEmployeeById(id);
});


app.MapGet("/employees", ([FromServices] IDataRepository db) =>
{
    return db.GetEmployees();
}
);

app.MapPut("/employee/{id}", ([FromServices] IDataRepository db, Employee employee) =>
{
    return db.PutEmployee(employee);
});

app.MapPost("/employee", ([FromServices] IDataRepository db, Employee employee) =>
{
    return db.AddEmployee(employee);
});

app.Run();
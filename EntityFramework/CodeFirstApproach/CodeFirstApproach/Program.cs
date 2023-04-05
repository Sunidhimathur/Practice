using System;

namespace CodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                Programme p = new Programme();
                p.Id = 100;
                p.Title = "B.Tech";
                p.Duration = 4;
                p.Fees = 500000;
                db.Programmes.Add(p);
                db.SaveChanges();
                Console.WriteLine("Database created!");
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

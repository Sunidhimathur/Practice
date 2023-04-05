using System;

namespace DatabaseFirstApproach
{
    class CRUD
    {
        public static void Main(string[] args)
        {
            OfficeDataEntities officeDataEntities = new OfficeDataEntities();
            Department department = new Department();

            int opt;
            int id;
            do
            {
                Console.WriteLine("1:New Record\n2:Display Record\n3:Update Record\n4:Delete Record\n5:Exit");
                Console.Write("Enter your option: ");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1: //add new record
                        Console.WriteLine("Enter ID, Name and Location:");
                        department.ID = Convert.ToInt32(Console.ReadLine());
                        department.Name = Console.ReadLine();
                        department.Location = Console.ReadLine();

                        officeDataEntities.Departments.Add(department);
                        officeDataEntities.SaveChanges();
                        break;

                    case 2: //read all records
                        foreach(Department d in officeDataEntities.Departments)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}", d.ID.ToString(), d.Name.ToString(), d.Location.ToString());
                        }
                        break;

                    case 3: //update record
                        Console.WriteLine("Enter ID to Update: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        department = officeDataEntities.Departments.Find(id);
                        if(department == null)
                        {
                            Console.WriteLine("Invalid Department Id, Try again!");
                        }
                        else
                        {
                            Console.WriteLine("Enter Modified Department Name and Location");
                            department.Name = Console.ReadLine();
                            department.Location = Console.ReadLine();
                            officeDataEntities.SaveChanges();
                        }
                        break;

                    case 4: //delete record
                        Console.WriteLine("Enter ID to Delete: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        department = officeDataEntities.Departments.Find(id);
                        if (department == null)
                        {
                            Console.WriteLine("Invalid Department Id, Try again!");
                        }
                        else
                        {
                            officeDataEntities.Departments.Remove(department);
                            officeDataEntities.SaveChanges();
                        }
                        break;

                    case 5: break;
                    default: 
                        Console.WriteLine("Invalid Option!"); break;
                }
            }
            while (opt != 5);
        }
    }
}

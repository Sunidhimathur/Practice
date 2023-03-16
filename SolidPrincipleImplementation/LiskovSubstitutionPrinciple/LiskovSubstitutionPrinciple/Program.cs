using LiskovSubstitutionPrinciple.Abstract;
using LiskovSubstitutionPrinciple.Implementation;
using LiskovSubstitutionPrinciple.Interface;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L: Liskov Substitution Principle (LSP)!");
            Console.ReadLine();

            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>
            {
                new PermanentEmployee(1, "John"),
                new TemporaryEmployee(2, "Jason"),
                new ContractEmployee(3, "Mike")
            };

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}

/*L in the SOLID is acronym for Liskov Substitution Principle which is also 
known as LSP.

Definition : Substitutability is a principle in object-oriented programming 
and it states that, in a computer program, if S is a Subtype of T, then 
objects of type T may be replaced with objects of type S.

1. Which means, Derived types must be completely substitutable for their 
   base types.

2. More formally, the Liskov substitution principle (LSP) is a particular 
   definition of a subtyping relation, called (strong) behavioral subtyping.

3. This principle is just an extension of the Open Close Principle.*/


/*Implementation guidelines : In the process of development we should ensure that  

1. No new exceptions can be thrown by the subtype unless they are part of the 
   existing exception hierarchy.

2. We should also ensure that Clients should not know which specific subtype 
   they are calling, nor should they need to know that. The client should 
   behave the same regardless of the subtype instance that it is given.

3. And last but not the least, New derived classes just extend without 
   replacing the functionality of old classes.*/
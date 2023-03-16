using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O: Open Closed Principle (OCP)!");
            Console.ReadLine();

            // Code before Open Closed Principle:

            /*Employee empJohn = new Employee(1, "John", "Permanent");
            Employee empJason = new Employee(2, "Jason", "Temp");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJason.ToString(),
                empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();*/


            // <--------------------------------------------------------> //


            // Code after Open Closed Principle Implementation:

            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJason.ToString(),
                empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}


/*O in the SOLID is acronym for “Open/Closed Principle” also known as OCP.

Definition: In object -oriented programming, the open/closed principle states 
that "software entities such as classes, modules, functions, etc. should be 
open for extension, but closed for modification".

Which means, any new functionality should be implemented by adding new classes, 
attributes and methods, instead of changing the current ones or existing ones.*/


/*Implementation guidelines
1. The simplest way to apply OCP is to implement the new functionality on new 
   derived(sub) classes that inherit the original class implementation.

2.Another way is to allow client to access the original class with an abstract 
  interface, 

3.So, at any given point of time when there is a requirement change instead of 
  touching the existing functionality it’s always suggested to create new 
  classes and leave the original implementation untouched.*/
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S: Single Responsibility Principle (SRP)!");
            Console.ReadLine();
        }
    }
}


/*S in the SOLID is acronym for Single Responsibility Principle (SRP).

As per the single responsibility principle:

1. A class should have only one reason to change
2. Which means, every module or class should have responsibility over a single 
   part of the functionality provided by the software, and that responsibility 
   should be entirely encapsulated by the class.*/

/*In Single Responsibility Principle 
1. Each class and module should focus on a single task at a time
2. Everything in the class should be related to that single purpose
3. There can be many members in the class as long as they related to the 
   single responsibility
4. With SRP, classes become smaller and cleaner
5. Code is less fragile */
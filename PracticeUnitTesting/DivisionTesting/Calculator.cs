using System;

namespace DivisionTesting
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            int result = numerator / denominator;
            return result;
        }

        public static void Main()
        {
            Console.WriteLine("Write value for numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write value for denominator");
            int denominator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result after division is: {0}", Divide(numerator, denominator));
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}

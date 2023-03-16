using System;

namespace AdditionTesting
{
    public class Addition
    {
        public static int AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("\nEnter First Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Second Number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is: {0}", AddTwoNumbers(n1, n2));
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}

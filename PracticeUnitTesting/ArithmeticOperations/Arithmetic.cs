using System;

namespace ArithmeticOperations
{
    public class Arithmetic
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public static void Main()
        {
            Arithmetic a = new Arithmetic();
            Console.WriteLine("Addition: {0}", a.Add(30, 20));
            Console.WriteLine("Subtraction: {0}", a.Sub(30, 20));
            Console.WriteLine("Multiplication: {0}", a.Mul(30, 20));
            Console.WriteLine("Division: {0}", a.Div(30, 20));
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}

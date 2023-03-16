namespace ArthmeticOperationsLibrary
{
    public class ArithmeticOperations
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        // To bypass a method through MOQ Framework always make it virtual so that it won't thow an error because of ovverriding the code.
        // Making the method virtual gives permission to ovverride the method in Mock Framework.
        public virtual bool CheckDigitsOnly()
        {
            return false;
        }

        public static void Main()
        {
            Console.WriteLine("Addition: {0}", Add(30, 20));
            Console.WriteLine("Subtraction: {0}", Sub(30, 20));
            Console.WriteLine("Multiplication: {0}", Mul(30, 20));
            Console.WriteLine("Division: {0}", Div(30, 20));
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();
        }
    }
}
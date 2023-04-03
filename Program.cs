namespace ComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            x = 9; y = 7;

            if (x == y)
                Console.WriteLine("X is equal to Y");
            else if (x != y)
            {
                // nested if
                if (x > y)
                    Console.WriteLine("X is greater than Y");
                else if (x < y)
                    Console.WriteLine("X is less than Y");

            }
        }
    }
}
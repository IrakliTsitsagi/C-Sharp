namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 7; i++)
            {
                // Console.WriteLine("First loop i = " + i);
                for (int j = 0; j <= 7; j++)
                {
                    Console.Write("0 ");
                    // Console.WriteLine("Second loop j = " + j);
                }
                Console.WriteLine();
            }

        }
    }
}
namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int.TryParse(Console.ReadLine(), out int x);
            if (x == 0)
            {
                Console.WriteLine("not valid input");
            }
            else
            Console.WriteLine("You have entered no. " + x);
        }
    }
}
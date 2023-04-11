namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome {0}", name);
        }
    }
}

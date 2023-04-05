namespace While_DoWhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int x = 1;
            while (x <= 10)
            {
                if (x == 7)
                    break;
                Console.WriteLine("this is line no. " + x);
                x++;
            }
            Console.WriteLine("_________");


            //do while loop

            int y = 1;

            do
            {
                Console.WriteLine("es aris xazi nomeri " + y);
                y++;
            } while (y <= 9);
        }

    }
}
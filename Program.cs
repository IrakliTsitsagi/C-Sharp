﻿namespace ConditionalStatementsIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            Console.WriteLine("Please Enter Number One");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Number Two");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {

                Console.WriteLine("Number one is greater than number two");
            }
            else if (x < y)
            {
                Console.WriteLine("Number one is less than number two");
            }
            else
            {
                Console.WriteLine("Number one is equal to nomber two");
            }
            Main(args);  // amis wyalobit rekursia xdeba da konsoli ar itisheba
        }
    }
}
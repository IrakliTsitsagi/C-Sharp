﻿namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int ricxvi = int.Parse(Console.ReadLine());

            if (ricxvi % 2 == 0)
                Console.WriteLine("number " + ricxvi + " is even");
            else
                Console.WriteLine("number " + ricxvi + " is odd");
            Main(args);
        }
    }
}
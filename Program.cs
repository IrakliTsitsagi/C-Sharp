﻿namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++) 
            {
                if (i == 3)
                    break;
                Console.WriteLine("Hello, World! " + i);
            }
           
        }
    }
}
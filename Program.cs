﻿namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND operator
            bool hasLicense = true;
            bool knowHowToDrive = false;

            if (hasLicense == true && knowHowToDrive == true)
                Console.WriteLine("You are good to go");

            else if (hasLicense == true && knowHowToDrive == false)
                Console.WriteLine("Cheateeer!!!");

            else if (hasLicense == false && knowHowToDrive == true)
                Console.WriteLine("you need to get license");


            else
                Console.WriteLine("That's not gonna happen pal");


            // OR operator

            bool wentForSwim = false;
            bool tookAShower = true;

            if (wentForSwim || tookAShower)
                Console.WriteLine("Pal you are so wet");

            else
                Console.WriteLine("You are not wet");
        }
    }
}
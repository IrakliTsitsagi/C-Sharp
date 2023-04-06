using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace LoopsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dan 100 mde luwi ricxvebi
            //for (int x = 2; x <= 100; x++)
            //{
            //    if ((x % 2) == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}


            // samkutxedi 0 ebit 10 x 10

            for (int i = 1; i <= 10; i++)
            {

                for (int y = 1; y <= i; y++)
                {

                    Console.Write("0 ");

                }
                Console.WriteLine();
            }
        }
    }
}



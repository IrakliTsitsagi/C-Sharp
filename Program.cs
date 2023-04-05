namespace StringManipulationPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "game of thrones";

            // index of
            Console.WriteLine(tvShow.IndexOf('o'));

            //last index of
            Console.WriteLine(tvShow.LastIndexOf('o'));

            // substring anu piuvlel asoebs ar dawers tuminda
            Console.WriteLine(tvShow.Substring(4));
            Console.WriteLine(tvShow.Substring(4, 9));

            // remove
            Console.WriteLine(tvShow.Substring(7));

            //insert sityvas amateb
            Console.WriteLine(tvShow.Insert(0,"the "));
            Console.WriteLine(tvShow.Insert(8, "the "));
        }
    }
}
namespace StringManipulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "game of thrones     ";
            string seasonOne = " - Season 1";
            string newName = "";

            newName = tvShow.Insert(tvShow.Trim().Length, seasonOne);
            Console.WriteLine(newName);

        }
    }
}
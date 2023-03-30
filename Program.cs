namespace DateTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formatedDate = "";
            // first format 30-03-2023 03:25:44
            formatedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}",myDate);
            Console.WriteLine(formatedDate);

            // second format : saturday of month september 2017

            formatedDate = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", myDate);
            Console.WriteLine(formatedDate);

            // third format day friday
            // month september
            // year 2023

            formatedDate = string.Format("{0: 'day' dddd \n 'month' MMMM \n 'year' yyyy}", myDate);
            Console.WriteLine(formatedDate);
        }
    }
}
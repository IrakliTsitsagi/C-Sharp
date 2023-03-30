namespace DateTimeLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime myDate = new DateTime(2023,5,1); // weli tve ricxvi
            DateTime myDate = DateTime.Now; //DateTime.Today; <-es saats ar achvenebs 
            string formattedDate = string.Format("date is {0:yyyy MMMM dd dddd mm ss}", myDate); /* sxvadasxva 
            formatebi */
            Console.WriteLine(formattedDate); 
        }
    }
}
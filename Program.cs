namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 4, 7, 9, 0 };
            // string[] weekDays = new string[7]{"Sunday", "Monday", "Tuesday", 
            // "Wednesday", "Thursday", "Friday", "Saturday"};

            // es uketesi gzaa
            string[] weekDays = {"Sunday", "Monday", "Tuesday",
                  "Wednesday", "Thursday", "Friday", "Saturday"};


            for (int i = 0; i < numbers.Length; i++)  // foris mere 2 jer tabi tavisit izavs, aseve foreachis mere
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var name in weekDays)
            {
                Console.WriteLine(name);
            }
        }
    }
}
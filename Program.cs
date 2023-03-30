namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("double is " + double_num + " float is " + float_num + " decimal is " + decimal_num);

            string firstName, lastName, house;
            firstName = "jon";
            lastName = "snow";
            house = "stark";

            Console.WriteLine("Hello " + firstName + " " + lastName + " of house " + house);

            bool isWorking;
            isWorking = true;

            Console.WriteLine(isWorking);

            int sum;
            sum = 0;

            int number1, number2;
            number1 = 5;
            number2 = 8;
            sum = number1 + number2;

            Console.WriteLine(sum);
        }
    }
}
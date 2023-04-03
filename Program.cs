namespace MoreLogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool username = false;
            bool email = false;
            bool password = true;

            if ((username || email) && password)
                Console.WriteLine("user is valid");

            else
                Console.WriteLine("something went wrong");

            
        }
    }
}
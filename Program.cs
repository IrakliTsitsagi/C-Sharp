namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 3.5f;
            accountNo = serialNo.ToString();

            Console.WriteLine(accountNo);


            // serialNo = Convert.ToInt32(anyNo); es amrgvalebs ricxvs anu gamoitans 3.5 ze 4 s

            // es qvemot ar amrgvalebs. 3.5 gamoitans 3
            serialNo = (int)anyNo;

            Console.WriteLine(serialNo);
        }
    }
}
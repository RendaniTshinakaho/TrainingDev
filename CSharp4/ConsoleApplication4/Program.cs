using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValue();
        }

        private static void GetValue()
        {
            string number = "Rendani";
            double price;
            bool results = double.TryParse(number, out price);
            if (results)
                Console.WriteLine(price);
            else
                Console.WriteLine("Failed to convert");
        }
    }
}

using System;
using System.Globalization;
using ConsoleApplication3.Enums;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);
            Display(Nut.Macadamia);
            string date = DateTime.Now.ToString("yy-mmm-dd ddd");
            Console.WriteLine(date);
            string s = true.ToString(CultureInfo.CurrentCulture);
            bool b = bool.Parse(s);
            string number = "13131313";
            int c = int.Parse(number);
            int i;
            bool failure = int.TryParse("rtyr", out i);
            if (!failure)
            {
                Console.WriteLine("Failed");
            }
            bool success = int.TryParse("234",out i);
            if (success)
            {
                Console.WriteLine("Success");
            }
            Console.WriteLine(c);
            Console.WriteLine(b);
        }

        private static void Display(Nut macadamia)
        {
            Console.WriteLine(macadamia);
        }
    }
}

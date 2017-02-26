using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            var results = ReverseString(word);
            Console.WriteLine(results);
        }

        public static string ReverseString(string s)
        {
            char[] arrayChar = s.ToCharArray();
            Array.Reverse(arrayChar);
            return new string(arrayChar);
        }
    }
}

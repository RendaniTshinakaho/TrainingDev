using System;

namespace ConsoleApplication2
{
    static class Program
    {
        static void Main(string[] args)
        {

            string word = string.Concat("Hello ", "World!".ToUpper());
            Console.WriteLine(word);
            Console.WriteLine(DateTime.Now);
        }
    }
}

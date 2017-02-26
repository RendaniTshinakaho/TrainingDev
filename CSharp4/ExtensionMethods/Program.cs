using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = StringHandler.IsCapitalized("rendani");
            Console.WriteLine(results); 
        }
    }

    public static class StringHandler
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            return char.IsUpper(s[0]);
        }
    }
}

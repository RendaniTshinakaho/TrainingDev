using System;

namespace FuncDelegate
{
    static class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> totalLength = (s2) => s2.Length;
            int total = totalLength("Hello");
            Console.WriteLine(total);
        }
    }
}

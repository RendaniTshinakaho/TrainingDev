using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal delegate int Transformer(int x);
    class Program
    {
    
        static void Main(string[] args)
        {
            Transformer t = Square;
            int result = t(3);
            Console.WriteLine(result);
        }

        private static int Square(int x)
        {
            return x*x;
        }
    }
}

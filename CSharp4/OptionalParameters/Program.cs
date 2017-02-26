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
            Transformer t = Square; //Create a delegate instance
            int result = t(3); //Invoke a delegate
            Console.WriteLine(result);
        }

        private static int Square(int x)
        {
            return x*x;
        }
    }

    public class Employee
    {
       
    }
}

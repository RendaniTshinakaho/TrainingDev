using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test.Display(null);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }

   public class Test
    {
       public static void Display(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Console.WriteLine();  
        }
    }
}

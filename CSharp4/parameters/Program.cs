using System;

namespace parameters
{
    static class Program
    {
        static void Main(string[] args)
        {
            Method(30,"Hi, There");
            Method("100","30");
            Method();
        }

        private static void Method( int x = 20,string word = "Hello World")
        {
            Console.WriteLine("x: {0} , word: {1}",x,word);
        }

        static void Method<T>(T x,T y)
        {
            Console.WriteLine("Two parameters (generic) Method :{0} and {1} ", x,y) ;
        }
    }
}

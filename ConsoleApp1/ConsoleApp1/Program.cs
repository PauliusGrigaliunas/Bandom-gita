using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Hi dudes, git works");
            a = Suma(2, 3);
            b = Sub(5, 3);
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
        static int Suma (int a, int b)
        {
            return a + b;
           
            
        }

        static int Sub(int a, int b) {
            return a - b;
        }


    }
}

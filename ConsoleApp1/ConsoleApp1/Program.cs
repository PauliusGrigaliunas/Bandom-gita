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
            int a, b, c;
            Console.WriteLine("Hi dudes, git works");
            a = Suma(2, 3);
            b = Sub(5, 3);
            c = Mul(2, 6);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
        static int Suma (int a, int b)
        {
            return a + b;    
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mul(int a1, int b1)
        {
            return a1 * b1;
        }
        
        static string SayingHi()
        {
            string greeting = "Oy m8!";
            return greeting;
        }
    }
}

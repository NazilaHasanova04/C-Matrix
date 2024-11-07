using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++ + ++a + --a + a--; // b=5+7+6+6=24 a=5
            Console.WriteLine(a+" "+b);
            Console.ReadKey();
        }
    }
}

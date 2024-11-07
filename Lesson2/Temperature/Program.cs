using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature with Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.Read());
            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"Temperature with Celsius is {celsius:F2}");
            Console.ReadKey();
        }
    }
}

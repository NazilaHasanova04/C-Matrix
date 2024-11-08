using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary: ");
            int salary = int.Parse(Console.ReadLine());

            int annualSalary = salary * 12;

            Console.WriteLine("Your annual salary is " + annualSalary);
            Console.ReadKey();
        }
    }
}

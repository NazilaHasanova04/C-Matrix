using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonn
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Task 1
            Console.WriteLine("Enter your salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter percentage: ");
            int percent = int.Parse(Console.ReadLine());
            float finalSalary = salary + (float)salary * percent / 100;
            Console.WriteLine("Result: " + finalSalary);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            // Task 2
            Console.WriteLine("Enter length of rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle: ");
            int width = int.Parse(Console.ReadLine());
            int area = width * length;
            Console.WriteLine("Area of rectangle: " + area);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            // Task 3
            Console.WriteLine("Enter AZN: ");
            float azn = float.Parse(Console.ReadLine());
            float dollar = azn / 1.7f;
            Console.WriteLine($"Converted to dollar: { dollar:F2}");
            Console.ReadKey();

        }


    }
}

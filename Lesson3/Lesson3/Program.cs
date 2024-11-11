using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            ConvertNumbersWithCasting();
            Console.WriteLine("Task 2:");
            CheckEmployee();
            Console.WriteLine("Task 3:");
            CalculateNumbers();
            Console.ReadKey();
        }
        static void CheckEmployee()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your gender: ");
            string gender = Convert.ToString(Console.ReadLine());

            if(age > 18 && salary >= 1000 && gender.ToLower() == "male")
            {
                Console.WriteLine("You are a suitable candidate in the labor market");
            }
            else if(age > 18 && salary >= 1000 && gender.ToLower() == "female")
            {
                Console.WriteLine("You are a suitable lady in the labor market");
            }
            else if (age < 18 && salary < 1000)
            {
                Console.WriteLine("You are a suitable to work");
            }
            else
            {
                Console.WriteLine("There is suitable information...");
            }
        }
        static void ConvertNumbersWithCasting()
        {
            Console.WriteLine("Enter integer value: ");
            int integerValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter double value: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter string value: ");
            string stringValue = Convert.ToString(Console.ReadLine());

            double convertedToDouble = integerValue;
            Console.WriteLine("Converted int to double: " + convertedToDouble);

            int convertedToInteger;
            if (doubleValue == (int)doubleValue)
            {
                convertedToInteger = (int)doubleValue;
            }
            else
            {
                Console.WriteLine("There may be a precision error");
                convertedToInteger = (int)doubleValue;
            }

            Console.WriteLine("Converted double to int: " + convertedToInteger);
        }
        static void CalculateNumbers()
        {
            Console.WriteLine("Please enter 3 integer number: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > 10 && num2 > 10 && num3 > 10)
            {
                double sum = Math.Pow(num1, 2) + Math.Pow(num2, 2) + Math.Pow(num3, 2);
                Console.WriteLine("Result: " + sum);
            }
            else if(num1 <= 0 || num2 <= 0 || num3 <= 0)
            {
                Console.WriteLine("We can not calculate...");
            }
            else
            {
                Console.WriteLine("Number ust be greater than 10...");
            }
            int greaterNumber = (num1 > num2 && num1 > num3) ? num1 : (num2 > num1 && num2 > num3) ? num2 :num3;

            Console.WriteLine("Greater number among them is " + greaterNumber);
        }
    }
}

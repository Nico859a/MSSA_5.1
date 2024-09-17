using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 
            Console.Write("Enter a number to calculate the sum of individual digits: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int remainder;

            while (num > 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }
            Console.WriteLine($"The sum of the digits of the number is: {sum}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given an integer x, return true if x is a palindrome, and false otherwise.

            Console.WriteLine("Enter number to check if palindrome: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int sum = 0;
            int temp = 0;
            temp = num;
            

            while (num > 0)
            {
                remainder = num % 10;
                sum = (sum *10) + remainder;
                num = num / 10;
            }

            if (sum == temp)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}

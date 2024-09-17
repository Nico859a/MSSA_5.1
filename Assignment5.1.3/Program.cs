using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
            int[] nums = new int[] { 1, 2, 3, 4, 5, 5};
            Console.WriteLine(DuplicateNumber(nums));
            Console.ReadKey();

        }

        static bool DuplicateNumber(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
           return false;

        }
    }
}

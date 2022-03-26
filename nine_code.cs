using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter a series of numbers separated by comma.
 * Find the maximum of the numbers and display it on the console.
 * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

namespace nine_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma ");
            var nums = Console.ReadLine();
            Console.WriteLine(nums);
            var new_nums=new string[nums.Length];
            new_nums= nums.Split(',');
            var max = 0;
            for(int i=0;i<new_nums.Length;i++)
            {
                var temp=Convert.ToInt32(new_nums[i]);
                if (temp > max)
                    max = temp;
            }
            Console.WriteLine("Maximum element is {0} ",max);
        }
    }
}

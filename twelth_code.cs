using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter 5 numbers. 
 * If a number has been previously entered, display an error message and ask the user to re-try.
 * Once the user successfully enters 5 unique numbers, sort them and display the result on the console*/

namespace twelth_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums=new List<int>();
            do
            {
                Console.WriteLine("Enter the number");
                var temp = Convert.ToInt32(Console.ReadLine());
                if (nums.Contains(temp))
                {
                    Console.WriteLine("Re-enter again ");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                nums.Add(temp);

            } while (nums.Count!=5);
            nums.Sort();
            foreach(int i in nums)
                Console.WriteLine(i);
        }
    }
}

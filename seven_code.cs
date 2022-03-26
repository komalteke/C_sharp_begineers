using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter a number.
 * Compute the factorial of the number and print it on the console.
 * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/

namespace seven_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            var num=Convert.ToInt32(Console.ReadLine());
            var fact = 1;
            while (num != 1)
            {
                fact=fact*num;
                num--;
            }
            Console.WriteLine("Factorial is {0}",fact);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program which takes two numbers from the console and displays the maximum of the two.*/

namespace second_code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            var num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            var num2=Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine("{0} is greater than {1}",num1,num2);
            }
            else if(num2 > num1)
            {
                Console.WriteLine("{0} is greater than {1}",num2,num1);
            }
            else
                Console.WriteLine("{0} and {1} are equal",num1,num2);
        }
    }
}

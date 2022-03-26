using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and continuously ask the user to enter a number or "ok" to exit. 
 * Calculate the sum of all the previously entered numbers and display it on the console.*/

namespace six_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            do
            {
                Console.WriteLine("Enter the number or ok to exit ");
                var num= Console.ReadLine();
                if (num.Equals("ok"))
                    break;
                else
                {
                    var temp = Convert.ToInt32(num);
                    sum += temp;
                }
            }while(true);
            Console.WriteLine("Sum of all previous number {0} ",sum);
        }
    }
}

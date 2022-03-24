using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter a number. The number should be between 1 to 10.
 * If the user enters a valid number, display "Valid" on the console. 
 * Otherwise, display "Invalid".
 * (This logic is used a lot in applications where values entered into input boxes need to be validated.)*/

namespace first_code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            var num=Convert.ToInt32(Console.ReadLine());
            if(num>=1 && num<=10)
            {
                Console.WriteLine("The number entered is valid ");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}

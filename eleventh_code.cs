using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter their name.
 * Use an array to reverse the name and then store the result in a new string.
 * Display the reversed name on the console.*/
namespace eleventh_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            var name=Console.ReadLine();
            var reversed = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversed+=name[i];
            }

            Console.WriteLine(reversed);


        }
    }
}

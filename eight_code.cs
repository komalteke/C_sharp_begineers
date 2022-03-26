using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that picks a random number between 1 and 10. 
 * Give the user 4 chances to guess the number.
 * If the user guesses the number, display “You won"; otherwise, display “You lost". 
 * (To make sure the program is behaving correctly, 
 * you can display the secret number on the console first.)*/

namespace eight_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(1, 10);
            int chance = 4;
            var flag = 0;
            while(chance > 0)
            {
                Console.WriteLine("Enter your guess ");
                var guess=Convert.ToInt32(Console.ReadLine());
                if(guess==num)
                {
                    flag = 1;
                    break;
                }
                else
                {
                    chance--;
                }    
            }
            if (flag == 0)
                Console.WriteLine("You lost. The correct guess is {0} ", num);
            else
                Console.WriteLine("You won.");
        }
    }
}

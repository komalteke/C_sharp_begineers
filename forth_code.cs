using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Your job is to write a program for a speed camera.
 * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
 * Write a program that asks the user to enter the speed limit. 
 * Once set, the program asks for the speed of a car.
 * If the user enters a value less than the speed limit, program should display Ok on the console.
 * If the value is above the speed limit,
 * the program should calculate the number of demerit points.
 * For every 5km/hr above the speed limit,
 * 1 demerit points should be incurred and displayed on the console.
 * If the number of demerit points is above 12, the program should display License Suspended.*/

namespace forth_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var demerit = 0;
            Console.WriteLine("Enter the speed limit : ");
            var speed=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the speed of car : ");
            var speed_car=Convert.ToDouble(Console.ReadLine());
            if (speed_car < speed)
                Console.WriteLine("Okay");
            else
            {
                
                while(speed_car != speed)
                {
                    demerit++;
                    speed_car-=5;
                }
            }
            if (demerit > 12)
                Console.WriteLine("License suspended");
            
        }
    }
}

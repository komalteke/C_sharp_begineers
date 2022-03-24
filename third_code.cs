using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter the width and height of an image. 
 * Then tell if the image is landscape or portrait.*/
namespace third_code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width : ");
            var width=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            var height=Convert.ToInt32(Console.ReadLine());
            if (width == height)
                Console.WriteLine("The image has 1:1 ratio ");
            else if (width > height)
                Console.WriteLine("The image is landscape");
            else
                Console.WriteLine("The image is portait");
        }
    }
}

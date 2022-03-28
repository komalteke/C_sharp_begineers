using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. 
 * Display the unique numbers that the user has entered*/

namespace thirtheen_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l=new List<int>();
            var temp = 0;
            do
            {
                Console.WriteLine("Enter the number or Quit ");
                var n=Console.ReadLine();
                if (n.Equals("Quit"))
                    break;
                temp=Convert.ToInt32(n);
                l.Add(temp);
            }while(true);
            var new_l=new List<int>();
            foreach(int i in l)
            {
                if (new_l.Contains(i))
                    continue;
                new_l.Add(i);
            }
            foreach(int i in new_l)
                Console.WriteLine(i);
        }
    }
}

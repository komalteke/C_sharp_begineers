using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*When you post a message on Facebook, depending on the number of people who like your post,Facebook displays different information.
•	If no one likes your post, it doesn't display anything.
•	If only one person likes your post, it displays: [Friend's Name] likes your post.
•	If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
•	If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/
namespace tenth_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namess=new List<string>();
            do
            {
                Console.WriteLine("Enter the names : ");
                var name=Console.ReadLine();
                if(name.Equals(""))
                {
                    break;
                }
                namess.Add(name);
            }while(true);
            if(namess.Count == 1)
                Console.WriteLine("[{0}] likes your photo ",namess[0]);
            else if(namess.Count == 2)
                Console.WriteLine("[{0}] and [{1}] likes your photo ",namess[0],namess[1]);
            else if(namess.Count>=3)
                Console.WriteLine("[{0}] , [{1}] and {2} likes your photo ",namess[0],namess[1],namess.Count()-2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool monday;
            //bool coffee;
            //Console.WriteLine("Is it monday?");
            //monday = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Is coffee is in the kitchen?");
            //coffee = Convert.ToBoolean(Console.ReadLine());
            //if (monday)
            //{
            //    if (coffee == false)
            //    {
            //        Console.WriteLine("Get the coffee:");   /*if there is one line of codeblock then no need of curly braces*/
            //    }
            //    else                                /*can also use "else if" for difficult decision making */
            //        Console.WriteLine("Have a cup of a coffee:");

            //    Console.WriteLine("Get to work:");
            //}
            //Console.WriteLine("Have fun:");
            //Console.ReadLine();




            Console.WriteLine("Bob's big giveaway");
            Console.Write("Choose a door:1, 2, 3:");
            string userValue = Console.ReadLine();
            
            /* another method of condition checking in C# is this,while having one condition*/

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You Won a ");                                      /*whenever userValue==1 then it will assign boat else strand of lint*/
            //Console.Write(message);
            
            //Console.Write(".");
            string result = "Have fun";
            Console.WriteLine("You won a {0} so {1}",message,result);          /* printing two values in a string*/
            Console.ReadLine();








        }
    }
}

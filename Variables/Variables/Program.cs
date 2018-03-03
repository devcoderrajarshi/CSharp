using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */


            Console.WriteLine("");
            Console.Write("Enter your first name:");
            //string myFirstName;
            //myFirstName = Console.ReadLine();
            string myFirstName = Console.ReadLine();  //short method for efficiency
            Console.Write("Enter your last name:");
            string myLastName= Console.ReadLine();
            

            Console.WriteLine("Hello, " + myFirstName+ " " + myLastName +" "+ "I am I-MAX");
            Console.ReadLine();


        }
    }
}

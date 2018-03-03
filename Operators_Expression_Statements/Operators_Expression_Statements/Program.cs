using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expression_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int x, y, a, b;
            // assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;
            //there are many mathematical operators addtion,subtraction,multiplication division operators
            x = (x + y) * (a - b);   //order of operaring using parenthesis

            if ((x > y) && (a > b))      // AND operator
            {
                Console.WriteLine("x and a both are biggest numbers");
            }
            if ((x > y) || (a > b))      // OR operator
            {
                Console.WriteLine("Either x or a is biggest number");
            }






        }
    }
}

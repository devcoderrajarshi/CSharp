using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 1;
            //numbers[3] = 16;
            //numbers[4] = 23;
            //numbers[5] = 25;      // overfolw error
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);    // length of the array by using ".Length"
            //Console.ReadLine();


            //int[] numbers = new int[] { 2, 5, 6, 4, 8, 15, 16 };       //assigning the values
            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David" };
            //for (int i = 0; i < names.Length; i++)                  //iterating through the array
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (string name in names)        // while iterating each value of "names[]" will be assigned into temporary string variable "name"
            //{
            //    Console.WriteLine(name);
            //}

            string zig = "You can get what you want out of life "+
                "if you help enough other people get what they want.";
            char[] charArray = zig.ToCharArray();   //breaking "zig" into every character and putting those into cahrArray[]
            Array.Reverse(charArray);                   //reversing "charArray[]"
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);              //printing the value of "charArray[]"
            }

            Console.ReadLine();


        }
    }
}

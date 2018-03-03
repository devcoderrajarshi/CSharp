using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";  //escapes the double quote and help to print double in the screen "\" is a escape character
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your C:\\drive";
            //string myString = @"Go to your C:\drive";      //@ is informing the .NET compiler to use "\" escape character inside of our string

            //string myString = String.Format("{0}=={1}", "First", "Second");

            // can also change the order

            //string myString = String.Format("{1}=={0}", "First", "Second");   //changing order

            //string myString = String.Format("{0}=={0}", "First", "Second");

            //string myString = String.Format("{1}=={1}", "First", "Second");


            //string myString = string.Format("{0:C}", 123.45);  // for currency representation use "C" 

            //string myString = string.Format("{0:N}", 1234567890);  //Normalisation of large numbers like commas and decimal points
            //string myString = String.Format("{0:P}",.05);    //for percentage representation using "P"

            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 1234567890);  //custom printing of numbers

            //string myString = " That summer we took threes across the board  ";   // for printing string from a particular point
            //myString = myString.Substring(6);                           //printing after sixth letter
            //myString = myString.Substring(6, 14);
            //specifying a range of letters
            //myString = myString.ToUpper();
            //Console.WriteLine(myString);
            //myString = myString.ToLower();
            //myString = myString.Replace(" ", "++");    //replacing 

            //myString = myString.Remove(6, 14);   //removing characters from the string within a given range



            //for triming off extra spaces from string

            //string myString = "";
            ////myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();       //compiler is adding all values and creating a new string
            //}


            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);                 //as same as previous one, just adding values to string to create a new string
            }





            Console.WriteLine(myString);          

            Console.ReadLine();
        }
    }
}

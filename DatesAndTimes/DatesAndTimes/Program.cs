using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Different types of format in DateTime representations

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.ToUniversalTime());
            //Console.WriteLine(myValue.AddDays(6).ToLongDateString());    //adding days with the current date
            //Console.WriteLine(myValue.AddDays(-6).ToLongDateString());      // subtracting days from the current date

            //Console.WriteLine(myValue.Month);                           //printing current month

            //DateTime myBirthDay = new DateTime(1996, 8, 24);          //initializing a DateTime Value to myBirthDay
            DateTime myBirthDay = DateTime.Parse("8/24/1996");          //another way

            Console.WriteLine(myBirthDay.ToLongDateString());
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);         //calling subtract method to get the difference between DateTime format
            Console.WriteLine(myAge.TotalDays);                         //capturing total number of days from the given DateTime value


          



            Console.ReadLine();
        }
    }
}

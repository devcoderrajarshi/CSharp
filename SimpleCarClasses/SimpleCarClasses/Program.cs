using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCarClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();            //its the  instance of the car class inside of the Program class as myCar
            myCar.Make = "Oldsmobile";              
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}",myCar.DetermineMarketValue());

            Console.ReadLine();

        }

        private static decimal DetermineMarketValue(Car cars)  //paasing an instance named cars as input parameter through the method "DetermineMarketValue"
        {
            decimal carValue = 100.0M;
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }         //these are the properties of car class
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()        //defining a method inside Car class "no static keyword"
        {                                            //also making it public to get access from anywhere in the program   
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;

            }
            return carValue;
        }
    }

}

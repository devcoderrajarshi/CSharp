using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(){
                new Car {VIN="A1",Make="BMW",Model="550i",Year=1981,StickerPrice=55000 },
                new Car { VIN="B2",Make="Toyota",Model="4Runner",Year=1993,StickerPrice=35000},
                new Car {VIN="C3",Make="BMW",Model="745li",Year=1998,StickerPrice=75000 },
                new Car {VIN="D4",Make="Ford",Model="Escape",Year=1988,StickerPrice=25000 },
                new Car {VIN="E5",Make="BMW",Model="55i",Year=1989,StickerPrice=57000}
            };

            /*
            //LINQ query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;

            
            */
            /*
            var orderofCars = from car in myCars
                              orderby car.Year descending   //orderby is making the collection sorted
                              select car;
            
            */
            //LINQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year==1998);

            //var orderofCars = myCars.OrderByDescending(p => p.Year);   // LINQ method
            //var firstBMW = myCars.First(p => p.Make == "BMW");
            /*
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");       //sorting then finding and assigning first "BMW"


            Console.WriteLine(firstBMW.VIN);        //printing
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year>1980));   //checking a condition true for all instances

            myCars.ForEach(p => p.StickerPrice -= 3000);               //direct operation on all stickerprice properties
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));  //using temporary instance (p) to print values
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //p is instance of collection (like input parameter) "Where()" returns the car
            //instances of cars having Make=="BMW" to bmws(a subset collection)
            //var helps to iterate through the whole collection.As we don't know 
            //what is going to be returned by "Where()" so we are giving the responsibility 
            //to compiler to figure out what the datatype will be

            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));   //returns a bool value if that condition
            //is satisfied or not


            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));     //total sum of prices of car instances


            /*
            foreach (var car in orderofCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year,car.Model, car.VIN, car.StickerPrice);
            }
            */
            Console.WriteLine(myCars.GetType());   //returns a datatype of the function
            var orderofCars = myCars.OrderByDescending(p => p.Year);  //as we don't know the datatype so we use var
            Console.WriteLine(orderofCars.GetType());

            //in this case we are creating a custom instance (newCars) having 
            //only two properties by checking a condition whether it is true or not
            var newCars = from car in myCars
                       where car.Make == "BMW"
                       select new {car.Make,car.Model };        //creating a anonymous datatype at the runtime not creating a datatype currently

            

            Console.WriteLine(newCars.GetType());

            


            Console.ReadLine();
            
            

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }


}

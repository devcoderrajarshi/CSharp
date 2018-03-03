using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car Car1 = new Car();
            Car1.Make = "Oldsmobile";           //assigning properties
            Car1.Model = "Cutlas Supreme";
            Car1.VIN = "A1";

            Car Car2 = new Car();
            Car2.Make = "Geo";
            Car2.Model = "Prism";
            Car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Rajarshi Das";
            b1.Title = "OOPs Principle";
            b1.ISBN = "0-000-00000-0";

            */
            //Old approach of collections to add different types of data which can generate errors

            /*
            //ArrayLists are dynamically sized,
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(Car1);       //adding data to collection "MyArrayList"
            myArrayList.Add(Car2);
            myArrayList.Add(b1);         //also adding different objects   
            myArrayList.Remove(b1);      //as the foreach loop is unable to relate Book object instance with Car through the iteration
            foreach (Car car in myArrayList)        //foreach is iterating and 
                                                    //giving the properties of "car1" and "car2" to the temp 
                                                    //object instance "car" 
            {
                Console.Write(car.Make);        //then we are printing "make" property
                Console.Write(" "+car.Model);
                Console.WriteLine();
            }
            

            //New Generic approach of collections to add same type of data which can remove errors >> List<>

            List<Car> myList = new List<Car>();   //more specifically creating an object instance

            myList.Add(Car1);
            myList.Add(Car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.Write(car.Make);   
                Console.Write(" " + car.Model);
                Console.WriteLine();
            }
            */
            /*
            //Dictionary<Tkey,Tvalue>      a new datatype contains key for a specific value

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(Car1.VIN, Car1);
            myDictionary.Add(Car2.VIN, Car2);
            Console.WriteLine("Enter a VIN number to get a car details:");
            string vin = Console.ReadLine();

            Console.Write(myDictionary[vin].Make);
            Console.WriteLine(" "+myDictionary[vin].Model);     //passing the key we are getting all the properties
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };   //assigning values in the time of instantiation


            /*
            //object initializer syntax.No need for constructor
            
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "B1" };   //assigning properties values in the time of instantiation

            //created new variable called Car then created new instance of car in computers memory
            //we are getting access to that memory using car1 label
            //then we assigned the property values

            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "B2" };    //same as above
            */

            //Collection Initializer syntax.
            //same as the previous one
           
            List<Car> myList = new List<Car>(){
                new Car {Make= "Oldsmobile",Model="Cutlas Supreme",VIN="C1" },
                new Car {Make="Nissan",Model="Alitima",VIN="C2" }
            };
            //done all the things in one line of code

            foreach (Car cartemp in myList)
            {
                Console.WriteLine(cartemp.Make);
            }





            Console.ReadLine();




        }
    }

    class Car
    {
        public string VIN { get; set; }   //making vehile identification number as key for our dictionary
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}

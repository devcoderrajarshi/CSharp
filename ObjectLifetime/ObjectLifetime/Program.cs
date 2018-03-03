using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();    //myCar is holding the address of the object instance 
                                       //"new Car();" in the computer's memory
            Car.MyMethod();
            





            myCar.Make = "Jaguar";
            myCar.Model = "Sting-Ray";
            myCar.Year = 2001;
            myCar.Color = "Silver";
            myCar.service(myCar.Year);

            /*
            //Car myThirdCar = new Car("Audi", "Hydragin", 1997, "Red");  //assigning the values while instantiation of "myThirdCar"


            //illiusion of the class with a object instance myAnotherCar
            Car myOtherCar;        //Allocating a space(Handle) in memory without creating instance(Bucket) nothing but address
            myOtherCar = myCar;       //copying the address to myAnotherCar from myCar(giving the power of myCar(created previously))
            Console.WriteLine("Old Value");
            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            
            myOtherCar.Year = 1990;

            //first print
            Console.WriteLine("New Value");
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            //both are addressing same memory bucket "myAnotherCar" and "myCar"
            //.NET framework library has garbage collection

                                               //removing the reference myAnotherCar from 
                                             //the current metohd(cutting a string from a two string baloon);
                                            //more deterministic way to handle references
            //myOtherCar = null  //same as manual garbage collection as we don't know when .NET framework library will execute garbage collection process through the execution of program

            //Second print(Error will occur "System.NullReferenceException")

            Console.WriteLine("Old Value");

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            */
            Console.ReadLine();
        }
    }

    class Car
    {
        //defining properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public void service(int year)
        {
            
            if (year < 2000)
                Console.WriteLine("Very old for service");
            else
                Console.WriteLine("Welcome");
        }
        /*
        public Car()             //constructor defining
        {
            Make = "Nissan";
        }

        
        public Car(string make,string model,int year, string color)    //overloaded version of Car() Class
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;


        }
        */
        
        //if we do not define constructor then the .NET framework runtime library will 
        //create a constructor at the instantiation and call it by default
        //like

        //public Car()             
        //  {
        //     
        //  }

        public static void MyMethod()         //as we are making this static we don't have to create
                                              //an instance of the "Car" class while using it's properties.
                                              //We simply can use it's methods using member access operator
        {
            Console.WriteLine("I am inside of MyMethod");

            Car NewCar = new Car();
            NewCar.Model = "LUICIFER";          //  Can not use a instance object inside a static method
                                                // we have to instantiate it (obviously with a value)
            Console.WriteLine(NewCar.Model);   
        }






    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandinScope
{
    class Program
    {
        private static string k = "";  //private field is private in nature
                                       //only available only to the member of current class
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = j+" "+i.ToString();
                k = i.ToString();
    
            }
            Console.WriteLine("\n");
            HelperMethod();
            Car myCar = new Car();
            myCar.DoSomething();




            //Console.WriteLine(i);                                     //i is only defined inside 
            //of the for so it is not available 
            //Console.WriteLine("Outside of the codeblock for \n"+j);   //outside (functionality of garbge collection)
            char[] num = j.ToCharArray();
            
            Array.Reverse(num);
            Console.WriteLine("Outside of the codeblock");
            
            foreach (char item in num)
            {
                Console.Write(" "+item);
            }
  
            Console.ReadLine();
        }

        public static void HelperMethod()
        {
            Console.WriteLine(k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()  //this private method is hidden 
                                        //from the user but we can call it with the help of
                                        //public method DoSomething() "Encapsulation"
        {
            return "Hello World";
        }
    }






}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // with and without functions a namegame
            //where different methods have different functionality to save time and increase readability of program

            Console.WriteLine("The Name Game");
            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your lastname name? ");
            string lastName = Console.ReadLine();

            Console.Write("In What city were you born? ");
            string city = Console.ReadLine();
            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += "";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += "";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */
            
            //string reversedFirstName = ReverseString(firstName);   //capturing whatever returned
            //string reversedLastName = ReverseString(lastName);
            //string reversedCity = ReverseString(city);


            //Console.Write(string.Format("{0} {1} {2}",
            //    reversedFirstName,
            //    reversedLastName,
            //    reversedCity));   //using "string.Format" to format the string
            //DisplayResult(reversedFirstName, reversedLastName, reversedCity);                 //less efficient
            DisplayResult(ReverseString(firstName)+" "+ ReverseString(lastName)+" "+ ReverseString(city));  ////more efficient
            Console.WriteLine();
            
            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
            Console.ReadLine();
            
            


        }

        private static string ReverseString(string message)
            {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);  //using "string.Concat(messageArray)" to concatenate again the total character Array
        }
        //method 1
        private static void DisplayResult(string reversedFirstNameloc, string reversedLastNameloc, string reversedCityloc)
        {
            Console.Write("Results: ");
            Console.Write(string.Format("{0} {1} {2}",
               reversedFirstNameloc,
               reversedLastNameloc,
               reversedCityloc));
        }
        //method 2
        //overloading of methods by changing number of variables (3 to 1 string)
        private static void DisplayResult(string mesasge)
        {
            Console.Write("Results: ");
            Console.Write(mesasge);
        }

    }
}

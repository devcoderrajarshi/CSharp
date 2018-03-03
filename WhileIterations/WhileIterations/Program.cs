using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIterations
{
    class Program
    {
        // simple game design
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose An Option: ");
            Console.WriteLine("1) Print Numbers: ");
            Console.WriteLine("2) Guessing Game: ");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number");
            int result = int.Parse(Console.ReadLine());  //parse converts the string representation of a number to its 32 bit signed integer equivalent
            int counter = 1;
            while (counter<result + 1)
            {
                Console.Write(counter);
                if (counter == result)
                {
                    Console.Write("");

                }
                else
                {
                    Console.Write("-");
                }


                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            Random myRandom = new Random();
            int RandomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == RandomNumber.ToString())
                    incorrect = false;
                else
                {
                    Console.WriteLine("Wrong!");
                }



            } while (incorrect);
            Console.WriteLine("Correct! it took {0} guesses", guesses);

            Console.ReadLine();
        }
    }
}

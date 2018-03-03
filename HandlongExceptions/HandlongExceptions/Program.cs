using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlongExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //we are using @ in the next line as we are using "\" 
                //in the statement to inform the compiler that we are using this for specifying a path
                //not for a escape character such as "\n"
                Console.WriteLine("Enter a File path with file name (with extension) to read: ");
                string pathwithname=Console.ReadLine();
                string content = File.ReadAllText(pathwithname);  //produce error (File does not exist)
                Console.WriteLine(content);
                
            }
            catch(FileNotFoundException ex)     //possible cases of exceptions
            {
                Console.WriteLine("There was a problem:  ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please check that file name that you typed is correct, for Example: Name.txt");
                
            }
            catch(DirectoryNotFoundException ex)        //possible cases of exceptions
            {
                Console.WriteLine("There was a problem:  ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please check that directory name that you typed is correct");
            }
            catch(Exception ex)         //Exception variable ex catches the error  (Generalised case for all possible errors)
            {
                Console.WriteLine("There was a problem:  ");        //creating user friendly output of errors 
                                                                    //so that they will understand
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                //closing database connections


                Console.WriteLine("Closing Application Now....");
            }

            Console.ReadLine();


        }
    }
}

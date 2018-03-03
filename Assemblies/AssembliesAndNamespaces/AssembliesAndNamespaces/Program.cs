using System;
using System.IO;
using System.Net;
namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example :Write one string to a file
            string text = "A class is the powerful data type in C#.Like a structure,a class defines the data and behaviour of the data type";
            //WriteAllText creates a file, writes the specified string 
            //and closes the file.You need not to call Flush() or close()



            File.WriteAllText(@"C:\Users\Rajarshi\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteText.txt", text);   //Full name of File Class can 

                                                                                                                                        //also be used in this line of code like "System.IO.File.WriteAllText()" 


            WebClient myClient = new WebClient();
            string html = myClient.DownloadString("http://msdn.microsoft");     //helps to download html string from webpage

            File.WriteAllText(@"C:\Users\Rajarshi\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteWebsiteHTML.txt",html);


            System.Console.WriteLine("Hello World!!");  //this is full name of Console Class
            Console.ReadLine();                  //as because this is in the current namespace
 
        }
    }
}

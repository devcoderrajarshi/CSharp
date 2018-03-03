using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //added reference to "MyCodeLibrary.dll" from the release folder to use 
            //it in our project (referencing just copied the library file to the bin directory of my project)
            Scrape myScrape = new Scrape();  //Creating instance of Scrape class
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}

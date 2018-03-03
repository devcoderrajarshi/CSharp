using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return getWebpage(url);
           
        }

        public string ScrapeWebpage(string url,string Filepath )
        {
            string reply = getWebpage(url);
            File.WriteAllText(Filepath, reply);
            return reply;
        }
        private string getWebpage(string url)       //encapsulated private method of same functionality
        {
            WebClient client = new System.Net.WebClient();
            return client.DownloadString(url);
        }

    }
}

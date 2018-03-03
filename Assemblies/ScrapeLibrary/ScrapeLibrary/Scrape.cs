using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return getWebpage(url);

        }

        public string ScrapeWebpage(string url, string Filepath)
        {
            string reply = getWebpage(url);
            File.WriteAllText(Filepath, reply);
            return reply;
        }
        private string getWebpage(string url)       //encapsulated private method of same functionality
        {
            WebClient client = new System.Net.WebClient();
            string content = client.DownloadString(url);
            content += "That's All";
            return content;
        }
    }
}
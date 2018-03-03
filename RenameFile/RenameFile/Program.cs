
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameFile
{
    class Program
    {
        public static string[] allnames = new string[200];
        public static int fileCounts;
        public static string[] numberfilename=new string[200];
        public static string[] letterfilename = new string[200];
        public static string[] finalnewfilename = new string[200];
        public static string subportion;
        //public static string newfilename;

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to trigger the operation of file renaming...");
            Console.ReadKey();
            filecount();
            getfilenames();
            desiredchar();
            remaingchar();
            //Rename();
            concate();
            //printname();
            RenameFile();
            Console.WriteLine("File names are rearranged as specified........");
            Console.WriteLine("Thank you.........");
            Console.ReadLine();
        }

        //get all the number of files
        private static void filecount()
        {
            fileCounts = Directory.GetFiles(@"C:\Users\Rajarshi\Desktop\test", "*.mp4", SearchOption.AllDirectories).Length;
            //Console.WriteLine(fileCounts);
            
        }

        //get all filenames in array
        private static void getfilenames()
        {
            

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(@"C:\Users\Rajarshi\Desktop\test");
            for (int i = 0; i < fileCounts; i++)
            {
                string currentname = Path.GetFileNameWithoutExtension(fileEntries[i]);
                allnames[i] = currentname;
            }

            /*
            foreach (string name in allnames)
            {
                Console.WriteLine(name);
            }
           */

        }

        private static void desiredchar()       
        {
            int p=0;


            foreach (string zig in allnames)
            {
                //strlen = zig.Length;
                //Console.WriteLine(strlen);
                if (zig != null)
                {
                    subportion = zig.Remove(0, zig.Length - 7);

                    numberfilename[p] = subportion;     //storing only the number portion of file
                    p++;
                    //Console.WriteLine(subportion);
                }
                else { break; }

            }

        }

        public static void remaingchar()
        {
            string lettersubportion;
            int k=0;
            foreach (string zig1 in allnames)
            {
                //strlen = zig.Length;
                //Console.WriteLine(strlen);
                if (zig1 != null)
                {
                    lettersubportion = zig1.Substring(0,zig1.Length-8);

                    letterfilename[k] = lettersubportion;           //storing only letter portion of file
                    k++;
                    //Console.WriteLine(subportion);
                }
                else { break; }

            }
        }



        // now we have numberfilename and letterfilename as array




        private static void concate()           //creating new filename
        {
            string newname;

            for (int i = 0; i < numberfilename.Length; i++)
            {
                
                
                newname = numberfilename[i] + " "+letterfilename[i];
                finalnewfilename[i] = newname;
                newname = "";
                
            }

   

        }



        /*
        public static void printname()          //collection having new names
        {
            foreach (string name in finalnewfilename)
            {
                Console.WriteLine(name);
            }
            foreach (string oldname in allnames)
            {
                Console.WriteLine(oldname);
            }
        }
        */

        //now we have two arrays of oldnames and newnames(finalnewname and allnames)


        //renaming Files

        private static void RenameFile()
        {
            try
            {
                for (int i = 0; i < numberfilename.Length; i++)
                {
                    string a, b;
                    a = @"C:\Users\Rajarshi\Desktop\test\" + allnames[i] + ".mp4";

                    b = finalnewfilename[i] + ".mp4";

                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(a, b);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }




















    }
}

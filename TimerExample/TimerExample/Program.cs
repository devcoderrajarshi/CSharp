using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer mytimer = new Timer(3000);
            mytimer.Elapsed += Mytimer_Elapsed;     //attaching a method with the
                                                    //timer to execute that code "(private static void Mytimer_Elapsed1())" after certain interval
            mytimer.Start();
            mytimer.Elapsed += Mytimer_Elapsed1;
            mytimer.Start();
            Console.WriteLine("Press Enter to remove red event: ");
            Console.ReadLine();
            
            mytimer.Elapsed -= Mytimer_Elapsed1;         //detaching method from the
                                                         //timer to stop execute that code

            Console.ReadLine();

        }

        private static void Mytimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed time :{0:HH:mm:ss.fff}", e.SignalTime);      //here e is the event argument
            
        }

        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed time :{0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}

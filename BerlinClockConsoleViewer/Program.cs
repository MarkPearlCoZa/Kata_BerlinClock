using System;
using BerlinClockGenerator;

namespace BerlinClockConsoleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var theTimeNow = DateTime.Now;
            var clock = new BerlinClock();
            Console.WriteLine("The berlin clock for {0} is ...\n", theTimeNow.ToString("hh:MM:ss"));
            Console.WriteLine(clock.Generate(theTimeNow));
            Console.ReadLine();
        }
    }
}

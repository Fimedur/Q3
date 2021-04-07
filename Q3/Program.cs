using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hour: ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double d = Math.Abs(hourInDegrees - minuteInDegrees);
            if (d > 180)
            {
                d = 360 - d;
            }
            Console.WriteLine($"The angle between hour hand and minute hand is {d} degrees");
            Console.ReadKey();
        }
    }
}

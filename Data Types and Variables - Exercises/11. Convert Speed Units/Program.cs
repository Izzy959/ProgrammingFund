using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSec = hours * 3600 + minutes * 60 + seconds;

            float metersPerSec = distanceMeters / totalSec;
            Console.WriteLine(metersPerSec);

            float kilometersPerHour = (distanceMeters / 1000) / (totalSec / 3600);
            Console.WriteLine(kilometersPerHour);

            float miles = distanceMeters / 1609;

            float milesPerHour = miles / (totalSec / 3600);
            Console.WriteLine(milesPerHour);


        }
    }
}

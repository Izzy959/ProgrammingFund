using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            short centuries = short.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            uint minutes = (uint)(hours * 60);
            decimal seconds = minutes * 60M;
            decimal milliSeconds = seconds * 1000M;
            decimal microSeconds = milliSeconds * 1000M;
            decimal nanoSeconds = microSeconds * 1000M;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes =" +
                $" {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}

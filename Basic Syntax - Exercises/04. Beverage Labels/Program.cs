using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = (Console.ReadLine());
            var Volume = Double.Parse(Console.ReadLine());
            var Energy = Double.Parse(Console.ReadLine());
            var Sugar = Double.Parse(Console.ReadLine());

            var energyContent = Volume / 100 * Energy;
            var sugarContent = Volume / 100 * Sugar;

            Console.WriteLine($"{Volume}ml {Name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}

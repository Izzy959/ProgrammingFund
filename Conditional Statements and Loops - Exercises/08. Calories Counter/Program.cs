using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var totalCal = 0;
            
           
            for (int i = 1; i <= count; i++)
            {
                var ingred = Console.ReadLine().ToLower();

                switch (ingred)
                {
                    case "cheese": totalCal = totalCal + 500; break;
                    case "tomato sauce": totalCal = totalCal + 150; break;
                    case "salami": totalCal = totalCal + 600; break;
                    case "pepper": totalCal = totalCal + 50; break;
                }
            }
            Console.WriteLine($"Total calories: {totalCal}");
                   


        }
    }
}

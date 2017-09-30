using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMonth = Console.ReadLine();
            var nightCount = int.Parse(Console.ReadLine());

        
            var discount = 0;
            var roomStudio = 0.0;
            var roomDouble = 0.0;
            var roomSuit = 0.0;
            

            switch (inputMonth)
            {
                case "May": 
                case "October":
                    
                        roomStudio = 50;
                        roomDouble = 65;
                        roomSuit = 75;
                    
                    break;
                case "June":
                case "September":
                    
                        roomStudio = 60;
                        roomDouble = 72;
                        roomSuit = 82;
                    
                    break;
                case "July":
                case "August":
                case "December":
                    
                        roomStudio = 68;
                        roomDouble = 77;
                        roomSuit = 89;
                    
                    break;
            }
            if ((inputMonth == "May" || inputMonth == "October") && nightCount > 7)
            {
                roomStudio *= 0.95;
            }
            else if ((inputMonth == "June" || inputMonth == "September") && nightCount > 14)
            {
                roomDouble *= 0.9;
            }
            else if ((inputMonth == "July" || inputMonth == "August" || inputMonth == "December") && nightCount > 14)
            {
                roomSuit *= 0.85;
            }

            var endStudio = roomStudio * nightCount;
            var endDouble = roomDouble * nightCount;
            var endSuit = roomSuit * nightCount;

           if ((inputMonth == "September" || inputMonth == "October") && nightCount > 7)
            {
                endStudio = endStudio - roomStudio;
            }
            Console.WriteLine($"Studio: {endStudio:f2} lv.");
            Console.WriteLine($"Double: {endDouble:f2} lv.");
            Console.WriteLine($"Suite: {endSuit:f2} lv.");








        }
    }
}

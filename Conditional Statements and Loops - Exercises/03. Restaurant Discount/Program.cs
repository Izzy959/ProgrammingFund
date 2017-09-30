using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine();

            var hallSize = "";
            var hallPrice = 0.00;
            var discountPackage = 0.00;
            var packagePrice = 0.00;
            var discount = 0.00;
            var pricePerson = 0.00;
            var totalPrice = 0.00;

            if (groupSize <= 50)
            {
                hallSize = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallSize = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallSize = "Great Hall";
                hallPrice = 7500;
            }
           

            switch (servicePackage)
            {
                case "Normal":
                    discountPackage = 0.05;
                    packagePrice = 500;
                    break;

                case "Gold":
                    discountPackage = 0.10;
                    packagePrice = 750;
                    break;

                case "Platinum":
                    discountPackage = 0.15;
                    packagePrice = 1000;
                    break;
            }

            totalPrice = hallPrice + packagePrice;
            discount = totalPrice - (discountPackage * totalPrice);
            pricePerson = discount / groupSize;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallSize}");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }





        }
    }
}

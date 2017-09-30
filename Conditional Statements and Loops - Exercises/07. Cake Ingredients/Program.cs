using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredNum = 0;
            for (int i = 1; i <= 20; i++)
            {
                var ingredients = Console.ReadLine();

                if (ingredients == "Bake!")
                {
                    break;
                    
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                }

                ingredNum++;

                
            }

            Console.WriteLine($"Preparing cake with {ingredNum} ingredients.");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars__prepisana_
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDMG = int.Parse(Console.ReadLine());
            var goshoDMG = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;
            var turn = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                turn++;
                if(turn %2 != 0)
                {
                    goshoHealth -= peshoDMG;
                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDMG;
                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if (turn % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

            
            
        }
    }
}

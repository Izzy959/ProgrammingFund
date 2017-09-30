using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats__
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: |{new String('|', currentHealth)}{new String('.', maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new String('|', currentEnergy)}{new String('.', maxEnergy - currentEnergy)}|");


        }
    }
}

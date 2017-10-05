using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= secondChar; i++)
            {
                char newChar = (char)i;
                Console.Write($"{newChar} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            object obj = string1 + " " + string2;
            Console.WriteLine(obj);
        }
    }
}

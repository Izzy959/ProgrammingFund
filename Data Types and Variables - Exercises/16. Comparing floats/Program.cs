using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(firstNum - secondNum) >= eps)
                Console.WriteLine("False");
            else if (Math.Abs(firstNum - secondNum) < eps)
                Console.WriteLine("True");
        }
    }
}

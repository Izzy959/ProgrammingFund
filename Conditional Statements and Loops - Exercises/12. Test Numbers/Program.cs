using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var combo = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    string result = $"{i} {j}";
                    combo++;
                    sum = sum + 3 * (i * j);

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combo} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                 
                   
                }
            }
            Console.WriteLine($"{combo} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

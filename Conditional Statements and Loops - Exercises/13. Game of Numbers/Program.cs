using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            var numCount = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    count++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        numCount++;
                        return;
                    }
                }
            }
            if (numCount == 0)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}

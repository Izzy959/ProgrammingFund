﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var diff = b - a;

            if (diff < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int l = a; l <= b; l++)
                            {
                                for (int m = a; m <= b; m++)
                                
                                    if (j <= i || k <= j || l <= k || m <= l) continue;

                                    else
                                    {
                                        Console.Write(i + " ");
                                        Console.Write(j + " ");
                                        Console.Write(k + " ");
                                        Console.Write(l + " ");
                                        Console.WriteLine(m);
                                    }

                                
                            }
                        }
                        
                    }
                }
            }

           
                
        }
    }
}

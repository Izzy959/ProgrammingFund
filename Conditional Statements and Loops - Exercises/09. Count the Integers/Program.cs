﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            try
            {
                var num = int.Parse(Console.ReadLine());

                while (true)
                {
                    i++;
                    num = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine(i);
            }
        }
    }
}

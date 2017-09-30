using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural__
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWord = Console.ReadLine();
            if (inputWord.EndsWith("y")) 
            {
                inputWord = inputWord.Remove(inputWord.Length - 1);
                inputWord = inputWord + "ies";
            }
            else if(inputWord.EndsWith("o") || inputWord.EndsWith("ch") || inputWord.EndsWith("s") || 
                    inputWord.EndsWith("sh") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
            {
               
                inputWord = inputWord + "es";
            }
            else
            {
                inputWord = inputWord + "s";
            }
            Console.WriteLine($"{inputWord}");
        }
    }
}

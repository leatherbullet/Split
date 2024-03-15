using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Учиться, учится и еще раз учится.";
            char[] separators = new char[] { ' ', ',', '.' };

            string[] words = text.Split (separators,StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Console.WriteLine($"подстрока: {word}");
            }
        }
    }
}

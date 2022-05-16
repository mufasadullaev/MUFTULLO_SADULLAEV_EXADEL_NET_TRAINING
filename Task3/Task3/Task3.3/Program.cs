using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            var userInput = Console.ReadLine();
            var cleanInput = Regex.Replace(userInput, @"[^(){}]", "");
            int len = cleanInput.Length;
            if ( len % 2 == 0)
            {
                Console.WriteLine($"Output: {cleanInput} - true");
            }
            else
            {
                Console.WriteLine($"Output: {cleanInput} - false");
            }
            Console.ReadLine();
        }
    }
}

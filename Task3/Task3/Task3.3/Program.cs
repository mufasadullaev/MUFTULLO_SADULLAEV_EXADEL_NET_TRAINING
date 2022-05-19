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
            Console.Write($"Output: {cleanInput} - ");
            if (CheckString(cleanInput))
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            Console.ReadLine();
        }
        public static bool CheckString(string input)
        {
            string error = "ERROR: EMPTY INPUT";
            if (string.IsNullOrEmpty(input))
                Console.WriteLine(error);
            Stack<char> brackets = new Stack<char>();
            foreach (var c in input)
            {
                if (c == '{' || c == '(')
                    brackets.Push(c);
                else if (c == '}' || c == ')')
                {
                    if (brackets.Count <= 0)
                        return false;
                    char open = brackets.Pop();
                    if (c == '}' && open != '{' ||
                        c == ')' && open != '(')
                        return false;
                }
            }
            if (brackets.Count > 0)
                return false;

            return true;
        }
    }
}

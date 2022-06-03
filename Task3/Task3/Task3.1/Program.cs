using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, LinkedList<string>> myDictionary = new Dictionary<char, LinkedList<string>>();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.Write("Input: ");
            string myInput = Console.ReadLine();
            string myCleanInput = Regex.Replace(myInput, @"[^a-zA-Z\s]+", "");
            string[] myArray = myCleanInput.Split(' ');
            foreach (char c in alphabet)
            {
                LinkedList<string> myList = new LinkedList<string>();
                foreach (string item in myArray)
                {
                    if (item[0].ToString().ToUpper() == c.ToString())
                    {
                        myList.AddLast(item);
                    }
                }
                myDictionary.Add(c, myList);
                Console.Write($"\n{c}: ");
                foreach (string name in myList)
                {
                    Console.Write($"'{name}' ");
                }
            }
            Console.ReadLine();
        }
    }
}

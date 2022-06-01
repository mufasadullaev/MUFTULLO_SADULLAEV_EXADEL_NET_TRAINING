using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task6
{
    public class ThreadFunc
    {
        public void FileOne()
        {
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\..\\..\\..\\FileOne.txt";
            string fileContent = File.ReadLines(filePath).First();
            string[] fileNumbers = fileContent.Split(',');
            int[] newArray = Array.ConvertAll(fileNumbers, int.Parse);
            string mathOperator = File.ReadLines(filePath).Last();
            Console.Write("Data from file 1: ");
            switch (mathOperator)
            {
                case "+":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("+");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x + y));
                    break;
                case "-":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("-");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x - y));
                    break;
                case "*":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("*");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x * y));
                    break;
                case "/":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("/");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x / y));
                    break;
            }
        }
        public void FileTwo()
        {
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\..\\..\\..\\FileTwo.txt";
            string fileContent = File.ReadLines(filePath).First();
            string[] fileNumbers = fileContent.Split(',');
            int[] newArray = Array.ConvertAll(fileNumbers, int.Parse);
            string mathOperator = File.ReadLines(filePath).Last();
            Console.Write("\nData from file 2: ");
            switch (mathOperator)
            {
                case "+":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("+");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x + y));
                    break;
                case "-":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("-");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x - y));
                    break;
                case "*":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("*");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x * y));
                    break;
                case "/":
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] < 0)
                        {
                            Console.Write($"({newArray[i]})");
                        }
                        else
                        {
                            Console.Write(newArray[i]);
                        }
                        while (i != newArray.Length - 1)
                        {
                            Console.Write("/");
                            break;
                        }
                    }
                    Console.Write("= " + newArray.Aggregate((x, y) => x / y));
                    break;
            }
        }
    }
}

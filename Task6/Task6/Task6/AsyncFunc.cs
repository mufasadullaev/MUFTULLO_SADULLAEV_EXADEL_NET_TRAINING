using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class AsyncFunc
    {
        public string filePath { get; private set; }
        public string fileContent { get; private set; }
        public string[] fileNumbers { get; private set; }
        public int[] newArray { get; private set; }
        public string mathOperator { get; set; }
        public async void AsyncTaskOne()
        {
            filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\..\\..\\..\\FileOne.txt";
            fileContent = File.ReadLines(filePath).First();
            fileNumbers = fileContent.Split(',');
            newArray = Array.ConvertAll(fileNumbers, int.Parse);
            mathOperator = File.ReadLines(filePath).Last();
            Console.Write("Data from file 1: ");
            await TaskOneCalculation();
            AsyncTaskTwo();
        }
        private Task TaskOneCalculation()
        {
            return Task.Factory.StartNew(() =>
            {
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
            });
        }
        public Task AsyncTaskTwo()
        {
            return Task.Factory.StartNew(() =>
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
            });
        }
    }
}

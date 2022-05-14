using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2");
            string newFile = @"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\NewFile.txt";
            /*            string fileLoc = AppDomain.CurrentDomain.BaseDirectory;
                        DirectoryInfo d = new DirectoryInfo(fileLoc);*/
            
            FileInfo[] f = d.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
/*            string newFile = $"{fileLoc}\\NewFile.txt";*/
            int fileNum = f.Length;
            List<string[]> result = new List<string[]>();
            for(int i = 0; i < fileNum; i++)
            {
                /*string myText = File.ReadAllText($"{fileLoc}\\File{i}.txt");*/
                string filepath = $"C:\\Users\\hacke\\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\\Task2\\Task2\\Task2.2\\File{i}.txt";
                string myText = File.ReadAllText($"{filepath}");
                string myCleanTxt = Regex.Replace(myText, @"[^a-zA-Z\s]+", "");
                string[] myResult = myCleanTxt.Split(' ');
                string uprLow = "";
                Console.WriteLine($"\nInitial String: {myText}");
                for (int x = myResult.Length - 1; x >= 0; x--)
                {
                    /*newReverse += myResult[x] + " ";*/
                    char[] myResultChar = myResult[x].ToCharArray();
                    /*for (int y = myResultChar.Length - 1; x >= 0; x--)*/
                    int len = myResultChar.Length;
                    string upr = "";
                    string low = "";
                    char ch;
                    for (int y = 0; y < len; y++)
                    {
                        ch = myResultChar[y];
                        if (ch >= 'A' && ch <= 'Z')
                        {
                            upr += ch;
                        }
                        else
                        {
                            low += ch;
                        }
                        uprLow = upr + low;
                    }
                    if (string.IsNullOrEmpty(uprLow))
                    {
                        Console.WriteLine($"String {i} is empty");
                    }
                    else
                    {
                        myResult[x] = uprLow;
                    }
                }
                result.Add(myResult);
                File.Delete($"{filepath}");
            }
            result = result.OrderBy(i => i.Length).ToList();
            using (StreamWriter sw = File.CreateText(newFile))
            {
                result.ForEach(i => {
                    Console.WriteLine(string.Join(" ", i));
                    sw.WriteLine(string.Join(" ", i));
                });
            }
            Console.ReadLine();  
        }
    }
}

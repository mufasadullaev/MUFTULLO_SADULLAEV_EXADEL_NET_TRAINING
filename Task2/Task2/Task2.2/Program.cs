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
            FileInfo[] f = d.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            string newFile = @"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\NewFile.txt";
            int fileNum = f.Length;
            for(int i = 0; i < fileNum; i++)
            {
                string filepath = $"C:\\Users\\hacke\\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\\Task2\\Task2\\Task2.2\\File{i}.txt";
                string myText = File.ReadAllText($"{filepath}");
                string myCleanTxt = Regex.Replace(myText, @"[^a-zA-Z\s*]+", "");

                string[] myResult = myCleanTxt.Split(' ');
                string newReverse = "";
                Console.WriteLine($"\nInitial String: {myText}");
                
                for (int x = myResult.Length - 1; x >= 0; x--)
                {
                    newReverse += myResult[x] + " ";
                }
                
                var endResult = newReverse.Substring(0, newReverse.Length - 1);
                Console.Write($"Reversed Clean String: {endResult}\n\n");
                using (StreamWriter sw = File.CreateText(newFile))
                {
                    sw.WriteLine(endResult);
                    /*File.Delete($"{filepath}");*/
                }
            }
            Console.ReadLine();
            
              
              
        }
    }
}

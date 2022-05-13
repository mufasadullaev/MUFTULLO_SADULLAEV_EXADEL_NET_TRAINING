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
            string mytext1 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File1.txt");
            Console.WriteLine(mytext1);
            string mytext2 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File2.txt");
            Console.WriteLine(mytext2);
            string mytext3 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File3.txt");
            Console.WriteLine(mytext3);
            string text1 = Regex.Replace(mytext1, @"[^a-zA-Z\s*]+", "");
            string text2 = Regex.Replace(mytext2, @"[^a-zA-Z\s*]+", "");
            string text3 = Regex.Replace(mytext3, @"[^a-zA-Z\s*]+", "");

            string[] result1 = text1.Split(' ');
            string answer1 = "";
            for (int i = result1.Length - 1;
                     i >= 0; i--)
            {
                answer1 += result1[i] + " ";
            }
            Console.Write(
            "\nReversed String 1: ");
            Console.Write(answer1.Substring(0,
                          answer1.Length - 1));

            string[] result2 = text2.Split(' ');
            string answer2 = "";
            for (int i = result2.Length - 1;
                     i >= 0; i--)
            {
                answer2 += result2[i] + " ";
            }
            Console.Write(
            "\nReversed String 2: ");
            Console.Write(answer2.Substring(0,
                          answer2.Length - 1));

            string[] result3 = text3.Split(' ');
            string answer3 = "";
            for (int i = result3.Length - 1;
                     i >= 0; i--)
            {
                answer3 += result3[i] + " ";
            }
            

            string path1 = @"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\NewFile.txt";
            File.Delete(path1);
            using (StreamWriter sw = File.CreateText(path1))
            {
                sw.WriteLine(answer1);
                sw.WriteLine(answer2);
                sw.WriteLine(answer3);

            }
            Console.Write(
            "\nReversed String 3: ");
            Console.Write(answer3.Substring(0,
                          answer3.Length - 1));
            Console.ReadLine();
        }
    }
}

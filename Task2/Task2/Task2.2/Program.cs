using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File1.txt");
            Console.WriteLine(text1);
            string text2 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File2.txt");
            Console.WriteLine(text2);
            string text3 = File.ReadAllText(@"C:\Users\hacke\MUFTULLO_SADULLAEV_EXADEL_NET_TRAINING\Task2\Task2\Task2.2\File3.txt");
            Console.WriteLine(text3);
            Console.ReadLine();
        }
    }
}

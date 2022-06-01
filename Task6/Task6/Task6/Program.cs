using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int method;
            Console.WriteLine(@"1. Asynchronous
2. Multi-threaded");
            Console.Write("Choose a method: ");
            method = Convert.ToInt32(Console.ReadLine());
            while (method != 1 && method != 2){
                Console.WriteLine("Please, choose 1 or 2");
                Console.WriteLine(@"1. Asynchronous
2. Multi-threaded");
                Console.Write("Choose a method: ");
                method = int.Parse(Console.ReadLine());
            }
            if (method == 1)
            {
                Console.WriteLine("\nAsyncronion method");
                Console.WriteLine();
            }
            else if (method == 2)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                Console.WriteLine("\nMulti-threaded method");
                Console.WriteLine();
                ThreadFunc threadFunc = new ThreadFunc();

                Thread fileOneCaller = new Thread(new ThreadStart(threadFunc.FileOne));
                fileOneCaller.Start();
                fileOneCaller.Join();

                Thread fileTwoCaller = new Thread(new ThreadStart(threadFunc.FileTwo));
                fileTwoCaller.Start();
                fileTwoCaller.Join();
                watch.Stop();
                Console.WriteLine($"\nExecution Time: {watch.ElapsedMilliseconds} ms");
            }
        }
    }
}

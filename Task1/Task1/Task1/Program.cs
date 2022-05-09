using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var text = "Number: ";

            for (; a < 10; a++)
            {
                Console.WriteLine(text + a);
                Console.ReadKey();
            }
        }
    }
}

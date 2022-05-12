using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            while (a > 0)
            {
                for (int i = a - 1; i > 0; i--)
                {
                    a *=i;
                }

            }
            
        }
    }
}

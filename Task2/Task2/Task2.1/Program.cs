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
            int a, i, f = 1;
            int b;
            double bresult;
            
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("Input the number A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calculate the natural logarithm of a given number:\n");
            Console.Write("Input the number B: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= 0 && a <= 5)
            {
                for (i = 1; i <= a; i++)
                    f = f * i;
                    var e = f * 0.05;
                Console.Write("The Factorial of {0} is: {1}\n", a, e);
                
            }
            else
            {
                Console.WriteLine("Input must be from 0 to 5 inclusively!");
            }

            if (b >=0 && a <= 100)
            {
                bresult = Math.Log(b);
                bresult = Math.Round(bresult, 2);
                Console.WriteLine($"The number B is equal to: {bresult}");
            }
            
            Console.ReadLine();
        }
    }
}

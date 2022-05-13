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
            double bResult;
            
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("Input the number A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Calculate the natural logarithm of a given number:\n");
            Console.Write("Input the number B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 5 & b >= 0 && b <= 100)
            {
                for (i = 1; i <= a; i++)
                    f = f * i;
                    double aResult = Math.Round(f * 0.05, 2);
                Console.Write($"The Factorial of {a} is: {aResult}\n");
                bResult = Math.Log(b);
                bResult = Math.Round(bResult, 2);
                Console.WriteLine($"The Natural Logarithm of {b} is: {bResult}");

                if ( aResult > bResult )
                {
                    Console.WriteLine($"Number 'a' = {aResult} and more than number 'b' = {bResult}");
                }
                else if ( aResult < bResult)
                {
                    Console.WriteLine($"Number 'a' = {aResult} and less than number 'b' = {bResult}");
                }
                else
                {
                    Console.WriteLine($"Number 'a' = {aResult} and equal to number 'b' = {bResult}");
                }
            }
            else if (a < 0 || a > 5)
            {
                Console.WriteLine("Input A must be from 0 to 5 inclusively!");

            }

            else 
            {
                Console.WriteLine("Input B must be from 0 to 100 inclusively!");
            }
            Console.ReadLine();
        }
    }
}

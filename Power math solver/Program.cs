using System;

namespace Power_math_solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t *** POWER MATH SOLVER ***");
            Console.ResetColor();
            Console.WriteLine("Please first Enter your base number then exponent number::");
            Console.Write("   --->> ");
            var baseNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("   --->> ");
            var pNumber = Convert.ToDouble(Console.ReadLine());

            var powerResult = POW(baseNumber, pNumber);
            Console.WriteLine("Your result is equal=  " + powerResult);
            System.Console.WriteLine();
        }
        static double POW(double x, double y)
        {
            double temp = 1;
            for (int i = 0; i < y; i++)
            {
                temp *= x;
            }
            return temp;
        }
    }
}

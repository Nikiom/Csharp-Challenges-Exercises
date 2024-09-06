using System;

namespace Challenge_No._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("\n    Pythagorean Theorem...");
            Console.ResetColor();

            System.Console.Write("Please enter your side A size:   ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Please enter your side B size:   ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            System.Console.Write("Your result of ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.Write("Pythagorean Theorem ");
            Console.ResetColor();
            Console.Write("is equal to::  " + c);
            System.Console.WriteLine("\n");
        }
    }
}

using System;
using System.Linq;

namespace New_folder__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args)
            {
                case { } when args.Length == 0:
                    Invalidation();
                    break;
                case { } when args[0] == "--helps" || (args[0] == "bmi" && args[1] == "--helps"):
                    System.Console.WriteLine();
                    Console.WriteLine("Use these switch to run program::");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("   --height         Your height (centimeters)");
                    Console.WriteLine("   --weight         Your weight (kilograms)");
                    Console.WriteLine("   --version        Show current version");
                    Console.WriteLine("   --helps          Show command list");
                    Console.ResetColor();

                    System.Console.WriteLine();
                    break;
                case { } when args[0] == "bmi":
                    bmiMethod(args);
                    break;
                default:
                    Invalidation();
                    break;
            }
        }
        static void bmiMethod(string[] args)
        {
            double height;
            double weight;
            switch (args)
            {
                case { } when args[1] == "--version":
                    System.Console.WriteLine();
                    Console.WriteLine("Current version is::  1.0");
                    System.Console.WriteLine();
                    break;
                // using this way for error handling ↓
                case { } when (args.Length == 5 && args[1] == "--height" && args[3] == "--weight"):
                    height = Convert.ToDouble(args[2]);
                    weight = Convert.ToDouble(args[4]);
                    bmiCalculator(height, weight);
                    break;
                case { } when (args.Length == 5 && args[1] == "--weight" && args[3] == "--height"):
                    weight = Convert.ToDouble(args[2]);
                    height = Convert.ToDouble(args[4]);
                    bmiCalculator(height, weight);
                    break;
                default:
                    Invalidation();
                    break;
            }
        }
        static void bmiCalculator(double height, double weight)
        {
            var bmiNumber = weight / (Math.Pow((height / 100), 2));
            System.Console.WriteLine();
            Console.WriteLine("Your BMI score is::  " + bmiNumber);
            bmiStatus(bmiNumber);
            System.Console.WriteLine();
        }
        static void bmiStatus(double bmi)
        {
            Console.WriteLine("According to your BMI your status is::");
            switch (bmi)
            {
                case { } when bmi <= 18.4:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t Underweight ");
                    break;
                case { } when (bmi >= 18.5 && bmi <= 24.9):
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t Normal ");
                    break;
                case { } when (bmi >= 25 && bmi <= 39.9):
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\t Overweight ");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t Obese ");
                    break;
            }
            Console.ResetColor();
        }
        static void Invalidation()
        {
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid command  :-?  :(");
            Console.WriteLine("use --help switch to show help.");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            System.Console.WriteLine();
        }
    }
}
using System;

namespace Find_Maximum___Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t*** Maximum & Minimum finder");
            Console.ResetColor();
            var myArray = ArrayDeclaration();
            var max = FindMax(myArray);
            var min = FindMin(myArray);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Your results are::  ↓↓↓");
            Console.ResetColor();
            Console.WriteLine($"-* Maximum number of your array is: {max} .");
            Console.WriteLine($"-* Minimum number of your array is: {min} .");
            System.Console.WriteLine();
        }
        static double[] ArrayDeclaration()
        {
            Console.Write("Enter size of your array::   ");
            var sizeOfArray = Convert.ToInt32(Console.ReadLine());
            var array = new double[sizeOfArray];
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write($"** Enter Array elements of index({i}): ==> ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();
            return array;
        }
        static double FindMax(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double FindMin(double[] array)
        {
            var min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}

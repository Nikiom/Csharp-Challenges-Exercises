using System;

namespace Find_Maximum___Minimum___V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t*** Maximum & Minimum finder");
            Console.ResetColor();
            var myArray = ArrayDeclaration();
            // var max = FindMax(myArray);
            // var min = FindMin(myArray);
            var myTuple = FindMaxMin(myArray);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Your results are::  ↓↓↓");
            Console.ResetColor();
            Console.WriteLine($"-* Maximum number of your array is: {myTuple.Item1} .");
            Console.WriteLine($"-* Minimum number of your array is: {myTuple.Item2} .");
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
        static Tuple<double, double> FindMaxMin(double[] array)
        {
            double max, min, temp;
            max = min = temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                if (max < temp)
                {
                    max = temp;
                }
                else if (min > temp)
                {
                    min = temp;
                }
            }
            return new Tuple<double, double>(max, min);
        }
    }
}
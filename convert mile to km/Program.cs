using System;

namespace Challenge_convert_mile_to_km
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.Write("Please enter you distance in miles::  ");
            double disMile = Convert.ToDouble(Console.ReadLine());
            double disKm = disMile * 1.60934;
            System.Console.WriteLine("      --> Your distance in km is: " + disKm);
            System.Console.WriteLine();
        }
    }
}
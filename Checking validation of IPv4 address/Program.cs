using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check whether an IPv4 address is valid or invalid.
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("\n    **...Validation of IPv4 address...**");
            Console.ResetColor();
            Console.WriteLine("Please enter your considered ip version 4 address::");
            var ip = Console.ReadLine();
            string[] ipArray = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
            // A valid IPv4 address consists of four numbers separated by dots
            ValidateLength(ipArray);
            // Each number must not contain leading zeroes
            ValidateZeroes(ipArray);
            // Each number must range from 0 to 255
            ValidateRange(ipArray);

            Console.WriteLine($"Your IP address ({ip}) is a valid IPv4 address...!");
            System.Console.WriteLine();
        }
        static void ValidateLength(string[] ipArray)
        {
            if (ipArray.Length != 4)
            {
                InvalidInput();
                Environment.Exit(0);
            }
        }
        static void ValidateZeroes(string[] ipArray)
        {
            foreach (var item in ipArray)
            {
                if (item.Length > 1 && item.StartsWith('0'))
                {
                    InvalidInput();
                    Environment.Exit(0);
                }
            }
        }
        static void ValidateRange(string[] ipArray)
        {
            foreach (var item in ipArray)
            {
                try
                {
                    int temp = Convert.ToInt32(item);
                    if (temp < 0 || temp > 225)
                    {
                        InvalidInput();
                        Environment.Exit(0);
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine($"\n     !!..{ex.Message}.!!");
                    InvalidInput();
                    Environment.Exit(0);
                }
            }
        }
        static void InvalidInput()
        {
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid input  :-?  :(");
            Console.WriteLine("Please try again.....");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
            System.Console.WriteLine();
        }
    }
}

using System;

namespace Challenge_Generating_a_random_password_including_numbers__letters_and_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     ...Generating random password....");
            Console.ResetColor();
            Console.WriteLine("Enter the size of your password::");
            Console.Write("  --->  ");
            var pas_size = Convert.ToInt32(Console.ReadLine());
            var chars = "qwertyuiop[]\asdfghjkl;'zxcvbnm,./`~!@#$%^&*(-_=+)QWERTYUIOPASDFGHJKLZXCVBNM<>?:1234567890";
            var stringChar = new char[pas_size];
            var random = new Random();
            for (int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i] = chars[random.Next(chars.Length + 1)];
            }
            var pas_result = stringChar;
            Console.WriteLine("Your result for password is::  ↓↓↓");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine(pas_result);
            Console.ResetColor();
        }
    }
}

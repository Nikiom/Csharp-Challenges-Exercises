using System;

namespace Displayer_Email_addresses
{
    class Program
    {
        static string[,] corporate = {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };
        static string[,] external = {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };
        static string externalDomain = "hayworth.com";
        static string internalDomain = "contoso.com";
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEmails for corporates:: -->");
            Console.ResetColor();
            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                // display internal email addresses
                DisplayEmailAddresses(corporate[i, 0], corporate[i, 1]);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Emails for externals:: -->");
            Console.ResetColor();
            for (int i = 0; i < external.GetLength(0); i++)
            {
                // display external email addresses
                DisplayEmailAddresses(firstName: external[i, 0], lastName: external[i, 1], false);
            }
            System.Console.WriteLine();
        }
        static void DisplayEmailAddresses(string firstName, string lastName, bool isCoWorker = true)
        {
            string email = firstName.Substring(0, 2) + lastName + "@" + (isCoWorker ? internalDomain : externalDomain);
            email = email.ToLower();
            System.Console.WriteLine(email);
        }
    }
}
using System;

namespace Challenge_of_converting_numbers_into_letters_and_days_of_the_week___me
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number to execute ::");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("  1) Convert number to alphabet");
                Console.WriteLine("  2) Convert number to day of week");
                Console.WriteLine("  3) Exit");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("--->   ");
                Console.ResetColor();
                var menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 to 10::");
                        var digit = Console.ReadLine();
                        var result = string.Empty;
                        switch (digit)
                        {
                            case "1":
                                result = "One";
                                break;
                            case "2":
                                result = "Two";
                                break;
                            case "3":
                                result = "Three";
                                break;
                            case "4":
                                result = "Four";
                                break;
                            case "5":
                                result = "Five";
                                break;
                            case "6":
                                result = "Six";
                                break;
                            case "7":
                                result = "Seven";
                                break;
                            case "8":
                                result = "Eight";
                                break;
                            case "9":
                                result = "Nine";
                                break;
                            case "10":
                                result = "Ten";
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   Your entry number is out of the Range...!!!");
                                Console.ResetColor();
                                break;
                        }
                        if (!string.IsNullOrEmpty(result))
                            Console.WriteLine("----->>  Result is: " + result);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1 to 7 for days of the week::");
                        var dayOfWeek = Console.ReadLine();
                        result = string.Empty;
                        switch (dayOfWeek)
                        {
                            case "1":
                                result = "Saturday";
                                break;
                            case "2":
                                result = "Sunday";
                                break;
                            case "3":
                                result = "Monday";
                                break;
                            case "4":
                                result = "Tuesday";
                                break;
                            case "5":
                                result = "Wednesday";
                                break;
                            case "6":
                                result = "Thursday";
                                break;
                            case "7":
                                result = "Friday";
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   Your entry number is out of the Range...!!!");
                                Console.ResetColor();
                                break;
                        }
                        if (!string.IsNullOrEmpty(result))
                            Console.WriteLine(" ----->>  Today base on you number is:  " + result);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\nThanks for using us :) ");
                        Console.WriteLine("   Good bye :) \n");
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You entered wrong item here..!!!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("   Please Try again...");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                }

            }
        }
    }
}
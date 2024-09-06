using System;

namespace Challenge_Word_guessing_game___me_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int minVal = 1;
            const int maxVal = 100;
            int gNum = random.Next(minVal, maxVal + 1);
            bool status = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t **** WORD GUESSING GAME ***");
            Console.ResetColor();
            var round = 0;
            do
            {
                Console.WriteLine($"Guese a number between {minVal} - {maxVal} ::");
                var mNum = Convert.ToInt32(Console.ReadLine());
                switch (mNum, gNum)
                {
                    case { } when mNum == gNum:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("   YOU WIN !!!!!");
                        Console.ResetColor();
                        round++;    ////////////////////////////////////////
                        Console.WriteLine("Round:  " + round);
                        Console.WriteLine("Would you like to play more..?   (Y/N)");
                        var ans = (Console.ReadLine()).ToLower();
                        if (ans == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("--------------------------");
                            Console.ResetColor();
                            gNum = random.Next(minVal, maxVal + 1);
                            round = -1;
                        }
                        else
                        {
                            status = false;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("--------------------------");
                            Console.ResetColor();
                        }
                        break;
                    case { } when (mNum > maxVal || mNum < minVal):
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your number is out of range...");
                        Console.WriteLine("Please Try again..!!!");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    case { } when gNum > mNum:
                        Console.WriteLine("   Guess:  " + mNum);
                        Console.WriteLine($"{mNum} is too low..!");
                        break;
                    case { } when gNum < mNum:
                        Console.WriteLine("   Guess:  " + mNum);
                        Console.WriteLine($"{mNum} is too high..!");
                        break;
                }
                round++;
            } while (status);

            Console.Write("Thanks for playing! .... ^-^");
            System.Console.WriteLine("\n");
        }
    }
}

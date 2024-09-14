using System;

namespace Rock_Paper_Scissors_Game
{
    class Program
    {
        static string[] gameSymbols = { "ROCK", "PAPER", "SCISSORS" };
        static void Main(string[] args)
        {
            var play_again = false;
            do
            {
                Console.Write("Enter ROCK, PAPER or SCISSORS::    ");
                var player = PlayerChoice();
                Console.WriteLine("Player:  " + player);
                var computer = ComputerChoice();
                Console.WriteLine("Computer:  " + computer);
                Console.WriteLine("---------------------------------------");
                GameResult(player, computer);
                play_again = PlayAgain();
                Console.WriteLine("---------------------------------------");
            } while (play_again);
            Console.WriteLine("\t ** Thanks for playing....\n");
        }
        static string PlayerChoice()
        {
            var player = ((Console.ReadLine()).Trim()).ToUpper();
            InputValidation(player);
            return player;
        }
        static string ComputerChoice()
        {
            var random = new Random();
            var computer = gameSymbols[random.Next(3)];
            return computer;
        }
        static void GameResult(string player, string computer)
        {
            switch (player, computer)
            {
                case { } when player == "ROCK" && computer == "SCISSORS":
                    PlayerWon();
                    break;
                case { } when player == "ROCK" && computer == "PAPER":
                    PlayerLose();
                    break;
                case { } when player == "PAPER" && computer == "ROCK":
                    PlayerWon();
                    break;
                case { } when player == "PAPER" && computer == "SCISSORS":
                    PlayerLose();
                    break;
                case { } when player == "SCISSORS" && computer == "PAPER":
                    PlayerWon();
                    break;
                case { } when player == "SCISSORS" && computer == "ROCK":
                    PlayerLose();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" >> It's a Draw...");
                    Console.ResetColor();
                    break;
            }
        }
        static void InputValidation(string hand)
        {
            foreach (var item in gameSymbols)
            {
                if (hand == item)
                {
                    return;
                }
            }
            BadCommand();
            Environment.Exit(0);
        }
        static void BadCommand()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nInvalid input  :(");
            Console.WriteLine("Sorry please try again......");
            Console.ResetColor();
            System.Console.WriteLine();
        }
        static void PlayerLose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" >> You Lose..!   :(");
            Console.ResetColor();
        }
        static void PlayerWon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" >> You Win..!   ^_^");
            Console.ResetColor();
        }
        static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again..? (Y/N)");
            var ans = ((Console.ReadLine()).Trim()).ToUpper();
            return ans == "Y" ? true : false;
        }
    }
}
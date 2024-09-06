using System;

namespace PP._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            var chn = 1;
            bool happy = false;
            do
            {
                Console.Clear();
                Console.Write("   ***CHANNEL ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($" {chn}");
                Console.ResetColor();
                Console.WriteLine("***");
                Console.WriteLine("Do you like this channel bro..?  (yes/no or space)");
                var ans = Console.ReadLine();
                if (ans == "yes" || ans == "y")
                {
                    Console.WriteLine($"Enjoy watching CHANNEL {chn}");
                    Console.WriteLine("     ^-^\n");
                    happy = true;
                }
                chn++;
            } while (!happy);
        }
    }
}
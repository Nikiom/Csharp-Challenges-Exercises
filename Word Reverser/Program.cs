using System;

namespace Word_Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input to reverse::");
            var word = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------------------------------");
            Console.ResetColor();

            Console.WriteLine("Your old word::   " + word);
            var newWord = ReverseWord(word);
            Console.WriteLine("Your new word::   " + newWord);
        }
        static string ReverseWord(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                result += word[word.Length - 1 - i];
            }
            // for (int i = word.Length - 1; i >= 0; i--)
            // {
            //     result += word[i];
            // }
            return result.ToUpper();
        }
    }
}
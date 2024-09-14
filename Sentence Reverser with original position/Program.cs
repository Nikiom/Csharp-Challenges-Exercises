using System;

namespace Sentence_Reverser_with_original_position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input to reverse::");
            var sentence = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------------------------------");
            Console.ResetColor();
            Console.WriteLine("Your old sentence::   " + sentence);
            var newSentence = ReverseSentence(sentence);
            Console.WriteLine("Your new sentence::   " + newSentence);
            System.Console.WriteLine();
        }
        static string ReverseSentence(string input)
        {
            string[] temp = input.Split(" ");
            var result = "";
            foreach (var item in temp)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item[item.Length - 1 - i];
                }
                result += " ";
                // Or you can call the method that we used in ( word reverser ) challenge.
                // result += ReverseWord(item) + " ";
            }
            // For additional space at the end of the sentence
            result = result.Trim();
            return result;
        }
    }
}

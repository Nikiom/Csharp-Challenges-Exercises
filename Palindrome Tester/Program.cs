using System;

namespace Palindrome_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "racecar", "talented", "deified", "tent", "tenet", "noon", "vendor", "civic" };
            System.Console.WriteLine();
            Console.WriteLine("Is it a palindrome..?");
            foreach (var item in words)
            {
                Console.WriteLine($"  - {item}: --> {IsPalindrome(item)}");
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Another version of comparison for being palindrome::");
            foreach (var item in words)
            {
                Console.WriteLine($"  - {item}: --> {IsPalindrome_2(item)}");
            }
            System.Console.WriteLine();
        }
        static bool IsPalindrome(string word)
        {
            var temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                temp += word[word.Length - 1 - i];
            }
            return temp == word;
        }
        static bool IsPalindrome_2(string word)
        {
            int start = 0;
            int end = word.Length - 1;
            while (start < end)
            {
                if (word[start] != word[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
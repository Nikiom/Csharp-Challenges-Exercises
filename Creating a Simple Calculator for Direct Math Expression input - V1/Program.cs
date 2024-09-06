using System;

namespace Creating_a_Simple_Calculator_for_Direct_Math_Expression_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       ..... Enter your math expression .....");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    **and use (space) between operand and operators**");
            Console.ResetColor();
            Console.Write("Your Input::   -->   ");
            string input = Console.ReadLine();

            var sp1 = input.IndexOf(" ");
            var sp2 = input.LastIndexOf(" ");
            var a = Convert.ToDouble(input.Substring(0, sp1));
            var b = Convert.ToDouble(input.Substring(sp2));
            char operand = input[sp1 + 1];
            double result = 0;
            switch (operand)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                case '%':
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("Sorry, Your operand is not supported here...!!!");
                    break;
            }
            Console.Write("Your operand is (");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(operand);
            Console.ResetColor();
            Console.WriteLine(").");
            Console.WriteLine("So Your result is::  ↓↓↓");
            System.Console.WriteLine(result);
        }
    }
}

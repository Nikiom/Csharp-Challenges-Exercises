using System;

namespace Creating_a_Simple_Calculator_for_Direct_Math_Expression_input___V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       ..... Enter your math expression .....");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    **And use (space) between operand and operators**");
            Console.WriteLine("          **Your operands are -> {+,-,*,/,%}**");
            Console.ResetColor();
            Console.Write("Your Input::   -->   ");
            string input = Console.ReadLine();

            char[] op = { '+', '-', '*', '/', '%' };
            var operand = ' ';
            for (int i = 0; i < op.Length; i++)
            {
                if (input.Contains(op[i]))
                    operand = op[i];
            }
            string[] input2 = input.Split(operand);
            var a = Convert.ToDouble(input2[0]);
            var b = Convert.ToDouble(input2[1]);
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

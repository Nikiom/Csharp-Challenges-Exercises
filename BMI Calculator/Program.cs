using System;

namespace Challenge_BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t .....BMI Calculator.....");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.Write("Please Enter your Height:: (cm) \t--> ");
            var height = (Convert.ToDouble(Console.ReadLine())) / 100;
            Console.Write("Now please Enter your Weight:: (kg) \t--> ");
            var weight = Convert.ToDouble(Console.ReadLine());

            var bmi = weight / (Math.Pow(height, 2));

            Console.WriteLine("\nYour BMI is = " + bmi);
            if (bmi <= 18.4)
            {
                Console.WriteLine("According to your BMI your status is::");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t Underweight ");
                Console.ResetColor();
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("According to your BMI your status is::");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\t Normal ");
                Console.ResetColor();
            }
            else if (bmi >= 25 && bmi <= 39.9)
            {
                Console.WriteLine("According to your BMI your status is::");
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t Overweight ");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("According to your BMI your status is::");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Obese ");
                Console.ResetColor();
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}

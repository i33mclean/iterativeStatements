// Programmer: Ian McLean
// Comments: This C# Console application acts as a conversion table to convert CADs to USD



using System;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stores the conversion value
            decimal conversionValue = 0.792367M;

            // Ask the user for input
            Console.WriteLine("Please enter a value between 5 and 25");
            var isInt = int.TryParse(Console.ReadLine(), out var increment);

            // Validates user input
            while (increment > 25 || increment < 5 || !isInt)
            {
                // Message to user if value is not accepted
                Console.WriteLine("Value is not an integer or is too small or too large! Please try again:");
                isInt = int.TryParse(Console.ReadLine(), out increment);
            }
            


            // For loop to start at 0 CAD and never exceed 200 CAD
            for (int i = 0; i <= (200 / increment); i++)
            {
                    Console.WriteLine($"{i * increment}\t{i * increment * conversionValue}");

            }
        }
    }
}

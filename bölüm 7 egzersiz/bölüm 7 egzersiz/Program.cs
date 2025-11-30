// PositiveNegativeZeroSummary.cs
// Determines if an integer is positive, negative, or zero and summarizes results.
using System;

class PositiveNegativeZeroSummary
{
    static void Main()
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        string? choice;

        do
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = FindIntType(number);

            if (result == 1)
            {
                Console.WriteLine("The number is POSITIVE.\n");
                positiveCount++;
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is NEGATIVE.\n");
                negativeCount++;
            }
            else
            {
                Console.WriteLine("The number is ZERO.\n");
                zeroCount++;
            }

            Console.Write("Do you want to enter another number? (y/n): ");
            choice = Console.ReadLine();
            Console.WriteLine();

        } while (choice?.ToLower() == "y");

        Console.WriteLine("---- SUMMARY ----");
        Console.WriteLine($"Positive numbers: {positiveCount}");
        Console.WriteLine($"Negative numbers: {negativeCount}");
        Console.WriteLine($"Zeros: {zeroCount}");
    }

    // Expression-bodied method using Math.Abs
    static int FindIntType(int number) =>
        (number == 0) ? 0 : (number == Math.Abs(number) ? 1 : -1);
}

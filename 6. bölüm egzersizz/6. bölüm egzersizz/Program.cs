// MultiplesOfFive.cs
using System;

namespace MultiplesOfFiveApp
{
    class MultiplesOfFive
    {
        static void Main()
        {
            Console.Write("How many numbers will you enter? ");
            int n = int.Parse(Console.ReadLine());

            int multiplesCount = 0;
            int nonMultiplesCount = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter number {i}: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 5 == 0)
                    multiplesCount++;
                else
                    nonMultiplesCount++;
            }

            Console.WriteLine($"\nNumber of multiples of 5: {multiplesCount}");
            Console.WriteLine($"Number of non-multiples of 5: {nonMultiplesCount}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

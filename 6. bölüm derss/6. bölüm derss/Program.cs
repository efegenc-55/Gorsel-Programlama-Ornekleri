// Sum.cs
// Summing integers with the for statement.
using System;

class Sum
{
    static void Main()
    {
        int total = 0; // initialize total

        // total even integers from 2 through 20
        for (int number = 2; number <= 20; number += 2)
        {
            total += number;
        }

        // display results
        Console.WriteLine($"Sum is {total}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

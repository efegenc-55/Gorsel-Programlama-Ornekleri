// ForCounter.cs
// Counter-controlled iteration with the for iteration statement.
using System;

class ForCounter
{
    static void Main()
    {
        // for statement header includes initialization,
        // loop-continuation condition and increment
        for (int counter = 1; counter <= 10; ++counter)
        {
            Console.Write($"{counter} ");
        }

        Console.WriteLine(); // new line after loop output
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}


// Fig. 7.7: RollDie.cs
// Roll a six-sided die 60,000,000 times.
using System;

class RollDie
{
    static void Main()
    {
        Random randomNumbers = new Random(); // random-number generator

        int frequency1 = 0; // count of 1s rolled
        int frequency2 = 0; // count of 2s rolled
        int frequency3 = 0; // count of 3s rolled
        int frequency4 = 0; // count of 4s rolled
        int frequency5 = 0; // count of 5s rolled
        int frequency6 = 0; // count of 6s rolled

        // summarize results of 60,000,000 rolls of a die
        for (int roll = 1; roll <= 60000000; ++roll)
        {
            int face = randomNumbers.Next(1, 7); // number from 1 to 6

            // determine roll value 1-6 and increment appropriate counter
            switch (face)
            {
                case 1:
                    ++frequency1;
                    break;
                case 2:
                    ++frequency2;
                    break;
                case 3:
                    ++frequency3;
                    break;
                case 4:
                    ++frequency4;
                    break;
                case 5:
                    ++frequency5;
                    break;
                case 6:
                    ++frequency6;
                    break;
            }
        }

        Console.WriteLine("Face\tFrequency"); // output headers
        Console.WriteLine($"1\t{frequency1}");
        Console.WriteLine($"2\t{frequency2}");
        Console.WriteLine($"3\t{frequency3}");
        Console.WriteLine($"4\t{frequency4}");
        Console.WriteLine($"5\t{frequency5}");
        Console.WriteLine($"6\t{frequency6}");

        Console.WriteLine("\nSimulation complete. Press any key to exit...");
        Console.ReadKey();
    }
}

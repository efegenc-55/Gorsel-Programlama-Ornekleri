// TowersOfHanoi.cs
// Solves the Towers of Hanoi problem using recursion.
using System;

class TowersOfHanoi
{
    static void Main()
    {
        Console.Write("Enter the number of disks: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSequence of moves:\n");
        MoveDisks(n, 'A', 'C', 'B'); // from A to C using B as auxiliary

        Console.WriteLine($"\nTotal moves required: {Math.Pow(2, n) - 1}");
    }

    // Recursive method to solve Towers of Hanoi
    static void MoveDisks(int n, char fromPeg, char toPeg, char auxPeg)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {fromPeg} -> {toPeg}");
            return;
        }

        // Move top n-1 disks from source to auxiliary
        MoveDisks(n - 1, fromPeg, auxPeg, toPeg);

        // Move the remaining disk from source to destination
        Console.WriteLine($"Move disk {n} from {fromPeg} -> {toPeg}");

        // Move n-1 disks from auxiliary to destination
        MoveDisks(n - 1, auxPeg, toPeg, fromPeg);
    }
}

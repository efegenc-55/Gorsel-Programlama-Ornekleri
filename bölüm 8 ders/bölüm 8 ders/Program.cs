// Fig. 8.4: InitArray.cs
// Calculating values to be placed into the elements of an array.
using System;

class InitArray
{
    static void Main()
    {
        const int ArrayLength = 5; // create a named constant
        int[] array = new int[ArrayLength]; // create array

        // calculate value for each array element
        for (int counter = 0; counter < array.Length; ++counter)
        {
            array[counter] = 2 + 2 * counter;
        }

        // display headings
        Console.WriteLine($"{"Index"}{"Value",8}");

        // output each array element's value
        for (int counter = 0; counter < array.Length; ++counter)
        {
            Console.WriteLine($"{counter,5}{array[counter],8}");
        }
    }
}

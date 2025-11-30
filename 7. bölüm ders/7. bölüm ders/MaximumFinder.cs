// Fig. 7.3: MaximumFinder.cs
// Method Maximum with three parameters.
using System;

class MaximumFinder
{
    // obtain three floating-point values and determine maximum value
    static void Main()
    {
        // prompt for and input three floating-point values
        Console.Write("Enter first floating-point value: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second floating-point value: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Enter third floating-point value: ");
        double number3 = double.Parse(Console.ReadLine());

        // determine the maximum of three values
        double result = Maximum(number1, number2, number3);

        // display maximum value
        Console.WriteLine($"\nMaximum is: {result}");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // returns the maximum of its three double parameters
    static double Maximum(double x, double y, double z)
    {
        double maximumValue = x; // assume x is the largest to start

        // determine whether y is greater than maximumValue
        if (y > maximumValue)
        {
            maximumValue = y;
        }

        // determine whether z is greater than maximumValue
        if (z > maximumValue)
        {
            maximumValue = z;
        }

        return maximumValue;
    }
}

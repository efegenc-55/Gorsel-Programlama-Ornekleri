// PythagoreanTriples.cs
using System;

namespace PythagoreanTriplesApp
{
    class Program
    {
        static void Main()
        {
            const int max = 500;

            Console.WriteLine("Pythagorean triples with sides no larger than 500:\n");

            for (int a = 1; a <= max; a++)
            {
                for (int b = a; b <= max; b++) // b >= a to avoid duplicates
                {
                    for (int c = b; c <= max; c++) // c >= b
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a}, {b}, {c}");
                        }
                    }
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

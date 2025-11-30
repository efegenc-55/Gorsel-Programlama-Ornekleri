// TypeOfParallelogram.cs
using System;

namespace ParallelogramApp
{
    class TypeOfParallelogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four nonzero integers:");

            Console.Write("Side 1: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Diagonal 1: ");
            int diagonal1 = int.Parse(Console.ReadLine());

            Console.Write("Diagonal 2: ");
            int diagonal2 = int.Parse(Console.ReadLine());

            // Check for nonzero input
            if (side1 <= 0 || side2 <= 0 || diagonal1 <= 0 || diagonal2 <= 0)
            {
                Console.WriteLine("\nError: All values must be nonzero positive integers.");
            }
            else
            {
                Console.WriteLine("\nResult:");

                if (side1 == side2 && diagonal1 == diagonal2)
                {
                    Console.WriteLine("The given values could represent a SQUARE.");
                }
                else if (side1 == side2 && diagonal1 != diagonal2)
                {
                    Console.WriteLine("The given values could represent a RHOMBUS.");
                }
                else if (side1 != side2 && diagonal1 == diagonal2)
                {
                    Console.WriteLine("The given values could represent a RECTANGLE.");
                }
                else
                {
                    Console.WriteLine("The given values do NOT represent a square, rhombus, or rectangle.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

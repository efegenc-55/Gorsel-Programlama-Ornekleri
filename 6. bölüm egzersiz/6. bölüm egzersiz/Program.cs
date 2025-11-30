// Permutations.cs
using System;
using System.Numerics;

namespace PermutationsApp
{
    class PermutationsCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n (nonnegative integer): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter r (nonnegative integer): ");
            int r = int.Parse(Console.ReadLine());

            if (n < 0 || r < 0)
            {
                Console.WriteLine("Error: n and r must be nonnegative integers.");
            }
            else if (r > n)
            {
                Console.WriteLine("Error: r cannot be greater than n.");
            }
            else
            {
                BigInteger permutation = Factorial(n) / Factorial(n - r);
                Console.WriteLine($"\nP({n},{r}) = {permutation}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Factorial method using BigInteger
        static BigInteger Factorial(int num)
        {
            BigInteger result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

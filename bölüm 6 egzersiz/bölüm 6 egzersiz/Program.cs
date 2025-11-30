// CompoundInterestInteger.cs
using System;

namespace CompoundInterestIntegerApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter principal amount in dollars (integer): ");
            int principalDollars = int.Parse(Console.ReadLine());
            int principal = principalDollars * 100; // convert to cents

            Console.Write("Enter annual interest rate (percent, e.g., 5 for 5%): ");
            int ratePercent = int.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());

            int amount = principal;

            for (int year = 1; year <= years; year++)
            {
                amount += amount * ratePercent / 100; // integer arithmetic in cents

                int dollars = amount / 100;
                int cents = amount % 100;
                Console.WriteLine($"Year {year}: {dollars}.{cents:D2}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

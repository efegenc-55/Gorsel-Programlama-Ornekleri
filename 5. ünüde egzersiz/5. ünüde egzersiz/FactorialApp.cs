// FactorialApp.cs
using System;
using System.Numerics; // Büyük sayılar için (BigInteger)

namespace FactorialApp
{
    class FactorialCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a nonnegative integer: ");
            string input = Console.ReadLine();

            // Kullanıcıdan alınan değeri kontrol et
            if (int.TryParse(input, out int n) && n >= 0)
            {
                BigInteger factorial = 1;

                // Faktöriyel hesaplama
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                // Sonucu göster
                Console.WriteLine($"\n{n}! = {factorial}");
            }
            else
            {
                Console.WriteLine("\nInvalid input! Please enter a nonnegative integer.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

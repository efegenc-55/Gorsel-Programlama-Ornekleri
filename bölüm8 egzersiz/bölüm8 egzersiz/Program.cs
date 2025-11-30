// Fig. 8.26: DiceRolling.cs
// Zar atma simülasyonu – 2 zar 36.000 kez atılır.
using System;

class DiceRolling
{
    static void Main()
    {
        Random random = new Random();  // Random nesnesi (tek bir tane yeterli)

        const int ROLLS = 36000;       // toplam zar atma sayısı
        int[] frequency = new int[13]; // [0–12], ama 2–12 arası kullanılacak

        // 36.000 kez zar atma
        for (int roll = 0; roll < ROLLS; roll++)
        {
            int die1 = random.Next(1, 7); // 1–6 arası
            int die2 = random.Next(1, 7); // 1–6 arası
            int sum = die1 + die2;

            frequency[sum]++; // çıkan toplamın sayısını arttır
        }

        // Sonuçları göster
        Console.WriteLine("Sum\tFrequency");
        for (int sum = 2; sum < frequency.Length; sum++)
        {
            Console.WriteLine($"{sum}\t{frequency[sum]}");
        }

        // Toplam kontrolü (güvenlik için)
        int totalRolls = 0;
        for (int i = 2; i < frequency.Length; i++)
        {
            totalRolls += frequency[i];
        }

        Console.WriteLine($"\nToplam zar sayısı: {totalRolls}");
    }
}

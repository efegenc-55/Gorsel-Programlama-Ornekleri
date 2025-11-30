// Identifying Multiples of Eight
using System;

class MultiplesOfEight
{
    static void Main()
    {
        const int SIZE = 5;                  // kaç sayı alınacak
        int[] numbers = new int[SIZE];       // kullanıcı girişlerini tutan dizi
        int count = 0;                       // kaç sayı girildiğini sayar

        Console.WriteLine("Lütfen 1 ile 1000 arasında 5 sayı girin:");

        while (count < SIZE)
        {
            Console.Write($"\n{count + 1}. sayıyı girin: ");
            if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 1000)
            {
                // sayıyı diziye ekle
                numbers[count] = input;
                count++;

                // her yeni sayı girildiğinde tüm mevcut sayıları göster
                Console.Write("Girilen sayılar: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();

                // eğer girilen sayı 8’in katıysa göster
                if (input % 8 == 0)
                {
                    Console.WriteLine($"✅ {input} sayısı 8'in katıdır.");
                }
            }
            else
            {
                Console.WriteLine("❌ Geçersiz giriş! 1 ile 1000 arasında bir tam sayı girin.");
            }
        }

        Console.WriteLine("\nTüm girişler tamamlandı!");
        Console.WriteLine("8'in katı olan sayılar:");
        foreach (int n in numbers)
        {
            if (n % 8 == 0)
                Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}

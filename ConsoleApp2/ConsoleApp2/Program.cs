using System;

namespace IfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan notu alıyoruz
            Console.Write("Öğrencinin notunu girin: ");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            // if...else yapısı başlıyor
            if (studentGrade >= 60)
            {
                // Eğer not 60 veya daha yüksekse burası çalışır
                Console.WriteLine("Passed");
            }
            else
            {
                // Eğer not 60’tan küçükse burası çalışır
                Console.WriteLine("Failed");
                Console.WriteLine("You must take this course again.");
            }

            // Programın kapanmaması için bekletiyoruz
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}

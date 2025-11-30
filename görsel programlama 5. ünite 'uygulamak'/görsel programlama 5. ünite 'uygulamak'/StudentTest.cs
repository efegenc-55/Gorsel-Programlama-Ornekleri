// Fig. 5.6: StudentTest.cs
// Create and test Student objects.
using System;

class StudentTest
{
    static void Main()
    {
        // 2 öğrenci nesnesi oluşturuluyor
        Student student1 = new Student("Jane Green", 93);
        Student student2 = new Student("John Blue", 72);

        // Birinci öğrencinin bilgilerini yazdır
        Console.Write($"{student1.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");

        // İkinci öğrencinin bilgilerini yazdır
        Console.Write($"{student2.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");

        Console.WriteLine("\nDevam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
}

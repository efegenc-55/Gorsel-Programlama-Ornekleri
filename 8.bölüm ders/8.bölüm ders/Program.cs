// Fig. 8.9: StudentPoll.cs
// Poll analysis app.
using System;

class StudentPoll
{
    static void Main()
    {
        // student response array (normalde kullanıcıdan alınabilir)
        int[] responses = { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3,
                            2, 3, 3, 2, 14 }; // sondaki 14 hata örneği için

        var frequency = new int[6]; // 0-5 arası dizinler (0 kullanılmaz)

        // her yanıtı kontrol et
        for (var answer = 0; answer < responses.Length; ++answer)
        {
            try
            {
                // responses[answer] değerine göre uygun frekans dizinini arttır
                ++frequency[responses[answer]];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($" responses[{answer}] = {responses[answer]}\n");
            }
        }

        Console.WriteLine($"{"Rating",7}{"Frequency",10}");

        // 1’den 5’e kadar tüm olası puanları göster
        for (var rating = 1; rating < frequency.Length; ++rating)
        {
            Console.WriteLine($"{rating,7}{frequency[rating],10}");
        }
    }
}

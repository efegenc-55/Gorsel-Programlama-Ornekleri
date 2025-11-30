using System;

class Time1Test
{
    static void Main()
    {
        var time = new Time1(); // Time1 nesnesi oluştur

        // Başlangıç zamanı
        Console.WriteLine($"The initial universal time is: {time.ToUniversalString()}");
        Console.WriteLine($"The initial standard time is: {time.ToString()}");
        Console.WriteLine();

        // Zamanı değiştir
        time.SetTime(13, 27, 6);
        Console.WriteLine($"Universal time after SetTime is: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time after SetTime is: {time.ToString()}");
        Console.WriteLine();

        // Geçersiz zaman ayarlamayı dene
        try
        {
            time.SetTime(99, 99, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }

        // Geçersiz deneme sonrası zaman
        Console.WriteLine("After attempting invalid settings:");
        Console.WriteLine($"Universal time: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time: {time.ToString()}");
    }
}

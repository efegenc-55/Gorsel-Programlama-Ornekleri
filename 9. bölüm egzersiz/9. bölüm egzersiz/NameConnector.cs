using System;
using System.Linq;

class NameConnector
{
    static void Main()
    {
        const int NUM_NAMES = 10;
        string[] names = new string[NUM_NAMES];

        // Kullanıcıdan 10 isim al
        for (int i = 0; i < NUM_NAMES; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        // İsimleri büyük harfe çevir
        string[] upperNames = names.Select(name => name.ToUpper()).ToArray();

        // Büyükten küçüğe sırala
        var descending = upperNames.OrderByDescending(name => name).ToArray();

        // Küçükten büyüğe sırala (ascending)
        var ascending = upperNames.OrderBy(name => name).ToArray();

        // Virgülle birleştirerek yazdır
        string joinedDescending = string.Join(", ", descending);
        string joinedAscending = string.Join(", ", ascending);

        Console.WriteLine("\nNames in uppercase:");
        Console.WriteLine(string.Join(", ", upperNames));

        Console.WriteLine("\nNames in descending order:");
        Console.WriteLine(joinedDescending);

        Console.WriteLine("\nNames in ascending order:");
        Console.WriteLine(joinedAscending);
    }
}

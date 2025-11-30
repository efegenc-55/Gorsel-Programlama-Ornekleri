using System;
using System.Linq;
using System.Collections.Generic;

class SortingPetsNames
{
    static void Main()
    {
        var petNames = new List<string>();

        // Kullanıcıdan isimleri al
        Console.WriteLine("Enter pet names (type 'done' to finish):");
        while (true)
        {
            Console.Write("Name: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            if (!string.IsNullOrWhiteSpace(input))
                petNames.Add(input);
        }

        if (petNames.Count == 0)
        {
            Console.WriteLine("No pet names entered.");
            return;
        }

        // a) Artan sırada karakter uzunluğuna göre
        var ascendingLength = petNames.OrderBy(name => name.Length).ToList();
        Console.WriteLine("\nPet names sorted by length (ascending):");
        foreach (var name in ascendingLength)
            Console.WriteLine(name);

        // b) Azalan sırada karakter uzunluğuna göre
        var descendingLength = petNames.OrderByDescending(name => name.Length).ToList();
        Console.WriteLine("\nPet names sorted by length (descending):");
        foreach (var name in descendingLength)
            Console.WriteLine(name);

        // c) Duplicate isimleri kaldır ve sayısını göster
        var distinctNames = petNames.Distinct().ToList();
        Console.WriteLine($"\nNumber of unique pet names: {distinctNames.Count}");
        Console.WriteLine("Unique pet names:");
        foreach (var name in distinctNames)
            Console.WriteLine(name);
    }
}

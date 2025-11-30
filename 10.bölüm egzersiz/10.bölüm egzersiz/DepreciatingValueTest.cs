using System;

class DepreciatingValueTest
{
    static void Main()
    {
        // Create three assets
        var asset1 = new DepreciatingValue(5000000);
        var asset2 = new DepreciatingValue(6000000);
        var asset3 = new DepreciatingValue(7000000);

        // Set AnnualDepreciationRate to 10%
        DepreciatingValue.AnnualDepreciationRate = 0.10;

        // Calculate annual depreciation and display new values
        asset1.CalculateAnnualDepreciation();
        asset2.CalculateAnnualDepreciation();
        asset3.CalculateAnnualDepreciation();

        Console.WriteLine("After 10% depreciation:");
        Console.WriteLine($"Asset1: {asset1.ValueOfAsset:C}");
        Console.WriteLine($"Asset2: {asset2.ValueOfAsset:C}");
        Console.WriteLine($"Asset3: {asset3.ValueOfAsset:C}");
        Console.WriteLine();

        // Set AnnualDepreciationRate to 11% for next three years
        DepreciatingValue.AnnualDepreciationRate = 0.11;

        for (int year = 1; year <= 3; year++)
        {
            asset1.CalculateAnnualDepreciation();
            asset2.CalculateAnnualDepreciation();
            asset3.CalculateAnnualDepreciation();

            Console.WriteLine($"After year {year} with 11% depreciation:");
            Console.WriteLine($"Asset1: {asset1.ValueOfAsset:C}");
            Console.WriteLine($"Asset2: {asset2.ValueOfAsset:C}");
            Console.WriteLine($"Asset3: {asset3.ValueOfAsset:C}");
            Console.WriteLine();
        }
    }
}

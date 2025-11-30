using System;

public class DepreciatingValue
{
    // Static property for annual depreciation rate (applies to all assets)
    public static double AnnualDepreciationRate { get; set; }

    // Instance property for current value of the asset
    public double ValueOfAsset { get; private set; }

    // Constructor to set initial value
    public DepreciatingValue(double initialValue)
    {
        if (initialValue < 0)
            throw new ArgumentOutOfRangeException(nameof(initialValue), "Value cannot be negative.");
        ValueOfAsset = initialValue;
    }

    // Method to calculate and apply annual depreciation
    public void CalculateAnnualDepreciation()
    {
        double depreciation = ValueOfAsset * AnnualDepreciationRate;
        ValueOfAsset -= depreciation;
    }
}

using System;

namespace AssetManagementApp
{
    // Asset class definition
    public class Asset
    {
        // Private fields
        private string assetName;
        private decimal assetValue;
        private decimal depreciationRate;

        // Properties with validation
        public string AssetName
        {
            get { return assetName; }
            set { assetName = value; }
        }

        public decimal AssetValue
        {
            get { return assetValue; }
            set
            {
                if (value >= 0)
                    assetValue = value;
            }
        }

        public decimal DepreciationRate
        {
            get { return depreciationRate; }
            set
            {
                if (value >= 0)
                    depreciationRate = value;
            }
        }

        // Constructor
        public Asset(string name, decimal value, decimal rate)
        {
            AssetName = name;
            AssetValue = value;
            DepreciationRate = rate;
        }

        // Method to calculate depreciation amount
        public decimal GetDepreciationAmount()
        {
            return AssetValue * (DepreciationRate / 100);
        }

        // Method to calculate depreciated value
        public decimal GetDepreciatedValue()
        {
            return AssetValue - GetDepreciationAmount();
        }

        // Method to increase asset value by 5%
        public void IncreaseValueByFivePercent()
        {
            AssetValue *= 1.05m;
        }

        // ToString override for easy display
        public override string ToString()
        {
            return $"Asset Name: {AssetName}\n" +
                   $"Value: {AssetValue:C}\n" +
                   $"Depreciation Rate: {DepreciationRate}%\n" +
                   $"Depreciation Amount: {GetDepreciationAmount():C}\n" +
                   $"Depreciated Value: {GetDepreciatedValue():C}";
        }
    }

    // Test class
    public class AssetTest
    {
        public static void Main(string[] args)
        {
            // Create two Asset objects
            Asset asset1 = new Asset("Computer", 5000m, 10m);
            Asset asset2 = new Asset("Vehicle", 20000m, 15m);

            Console.WriteLine("=== Initial Asset Records ===\n");
            Console.WriteLine(asset1);
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine(asset2);

            // Increase value by 5%
            asset1.IncreaseValueByFivePercent();
            asset2.IncreaseValueByFivePercent();

            Console.WriteLine("\n=== After Increasing Value by 5% ===\n");
            Console.WriteLine(asset1);
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine(asset2);

            // Test negative assignment (should be ignored)
            asset1.AssetValue = -100m;
            asset2.DepreciationRate = -20m;

            Console.WriteLine("\n=== After Trying Invalid Assignments ===\n");
            Console.WriteLine(asset1);
            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine(asset2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


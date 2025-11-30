// Coaching.cs
using System;

namespace CoachingApp
{
    // Coaching class definition
    public class Coaching
    {
        // Auto-implemented properties
        public string CoachingType { get; set; }
        public int NumberOfPlayers { get; set; }
        public string ClassTimings { get; set; }
        public decimal Charges { get; set; }

        // Constructor to initialize all properties
        public Coaching(string coachingType, int numberOfPlayers, string classTimings, decimal charges)
        {
            CoachingType = coachingType;
            NumberOfPlayers = numberOfPlayers;
            ClassTimings = classTimings;
            Charges = charges;
        }

        // Method to display coaching details
        public void DisplayDetails()
        {
            Console.WriteLine($"{CoachingType}\t{NumberOfPlayers}\t{ClassTimings}\t${Charges}");
        }
    }

    // Test class
    public class CoachingTest
    {
        public static void Main(string[] args)
        {
            // Create Coaching objects
            Coaching coaching1 = new Coaching("Football", 20, "Morning (8 AM - 10 AM)", 150.00m);
            Coaching coaching2 = new Coaching("Basketball", 15, "Evening (5 PM - 7 PM)", 200.00m);
            Coaching coaching3 = new Coaching("Tennis", 5, "Afternoon (2 PM - 4 PM)", 120.00m);

            // Display header
            Console.WriteLine("Coaching Type\tPlayers\tClass Timings\t\tCharges ($)");
            Console.WriteLine("---------------------------------------------------------------");

            // Display each coaching details
            coaching1.DisplayDetails();
            coaching2.DisplayDetails();
            coaching3.DisplayDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

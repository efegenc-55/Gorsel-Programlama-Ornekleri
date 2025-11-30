// HireCharges.cs
// Calculates cab fare and total earnings for all customers.
using System;

class HireCharges
{
    static void Main()
    {
        double totalEarnings = 0.0;
        string? choice;

        do
        {
            Console.Write("Enter kilometers travelled: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter waiting time (in hours, enter 0 if none): ");
            double waitingHours = Convert.ToDouble(Console.ReadLine());

            // Fare hesaplama metodu
            double fare = FindCabFare(kilometers, waitingHours);

            Console.WriteLine($"\nFare for this customer: ${fare:F2}\n");

            totalEarnings += fare;

            Console.Write("Another customer? (y/n): ");
            choice = Console.ReadLine();

            Console.WriteLine();

        } while (choice?.ToLower() == "y");

        Console.WriteLine($"Total earnings for yesterday: ${totalEarnings:F2}");
    }

    // Method to calculate fare for a customer
    static double FindCabFare(double kilometers, double waitingHours)
    {
        const double BASE_FARE = 13.00;
        const double ADDITIONAL_RATE = 1.68;
        const double WAITING_RATE = 30.00;

        double fare = BASE_FARE;

        if (kilometers > 5)
        {
            double extraKm = kilometers - 5;
            fare += Math.Ceiling(extraKm) * ADDITIONAL_RATE; // part km counts as full
        }

        double waitingCharge = waitingHours * WAITING_RATE;
        fare += waitingCharge;

        return fare;
    }
}

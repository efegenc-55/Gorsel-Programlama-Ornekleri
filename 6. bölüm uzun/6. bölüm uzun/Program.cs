// AutoPolicy.cs
using System;

namespace AutoInsuranceApp
{
    // Class that represents an auto insurance policy
    public class AutoPolicy
    {
        // Auto-implemented properties
        public int AccountNumber { get; set; }     // policy account number
        public string MakeAndModel { get; set; }   // car that policy applies to
        public string State { get; set; }          // two-letter state abbreviation

        // Constructor
        public AutoPolicy(int accountNumber, string makeAndModel, string state)
        {
            AccountNumber = accountNumber;
            MakeAndModel = makeAndModel;
            State = state;
        }

        // Returns whether the state has no-fault insurance
        public bool IsNoFaultState
        {
            get
            {
                bool noFaultState;

                // Determine whether state has no-fault auto insurance
                switch (State)
                {
                    case "MA":
                    case "NJ":
                    case "NY":
                    case "PA":
                        noFaultState = true;
                        break;
                    default:
                        noFaultState = false;
                        break;
                }

                return noFaultState;
            }
        }
    }

    // Test class
    public class AutoPolicyTest
    {
        static void Main(string[] args)
        {
            // Create two AutoPolicy objects
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");

            // Display whether each policy is in a no-fault state
            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method that displays whether an AutoPolicy
        // is in a state with no-fault auto insurance
        public static void PolicyInNoFaultState(AutoPolicy policy)
        {
            Console.WriteLine("The auto policy:");
            Console.Write($"Account #: {policy.AccountNumber}; ");
            Console.WriteLine($"Car: {policy.MakeAndModel};");
            Console.Write($"State: {policy.State}; ");
            Console.WriteLine(policy.IsNoFaultState ? "is a no-fault state" : "is not a no-fault state");
            Console.WriteLine();
        }
    }
}

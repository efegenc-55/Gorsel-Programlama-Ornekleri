using System;

namespace StudentRecordApp
{
    // Student class definition
    public class Student
    {
        // Auto-implemented properties
        public string StudentID { get; set; }
        public string Name { get; set; }

        private decimal subject1;
        private decimal subject2;
        private decimal subject3;

        // Properties with validation (no negative scores)
        public decimal Subject1
        {
            get { return subject1; }
            set
            {
                if (value >= 0)
                    subject1 = value;
            }
        }

        public decimal Subject2
        {
            get { return subject2; }
            set
            {
                if (value >= 0)
                    subject2 = value;
            }
        }

        public decimal Subject3
        {
            get { return subject3; }
            set
            {
                if (value >= 0)
                    subject3 = value;
            }
        }

        // Constructor
        public Student(string id, string name, decimal s1, decimal s2, decimal s3)
        {
            StudentID = id;
            Name = name;

            // Use properties to ensure validation
            Subject1 = s1;
            Subject2 = s2;
            Subject3 = s3;
        }

        // Method to calculate total marks
        public decimal GetAggregate()
        {
            return Subject1 + Subject2 + Subject3;
        }

        // Method to calculate percentage
        // Assuming maximum marks = 50 per subject (total 150)
        public decimal GetPercentage()
        {
            decimal totalMarks = GetAggregate();
            decimal maxMarks = 150m; // 50 * 3 subjects
            return (totalMarks / maxMarks) * 100;
        }

        // ToString override for easy display
        public override string ToString()
        {
            return $"ID: {StudentID}\nName: {Name}\nSubject1: {Subject1}\nSubject2: {Subject2}\nSubject3: {Subject3}\nAggregate: {GetAggregate()}\nPercentage: {GetPercentage():F2}%";
        }
    }

    // Test class
    public class StudentRecordTest
    {
        public static void Main(string[] args)
        {
            // Create a few student objects
            Student student1 = new Student("S101", "Efe Genç", 45m, 40m, 35m);
            Student student2 = new Student("S102", "Ayşe Demir", 50m, 48m, 49m);

            Console.WriteLine("=== Student Records ===\n");
            Console.WriteLine(student1);
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine(student2);

            // Test negative input (should be ignored)
            student1.Subject1 = -10m;
            Console.WriteLine("\nAfter trying to assign a negative score:");
            Console.WriteLine(student1);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

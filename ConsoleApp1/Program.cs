using System; // Import the System namespace for basic console functionality

class Program
{
    static void Main(string[] args)
    {
        
        bool exit = false;

     
        while (!exit)
        {
            // Display the main menu
            Console.WriteLine("\n==== DCIT318 Assignment 1 ====");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            
            string choice = Console.ReadLine();

            // Handle user's choice using switch-case
            switch (choice)
            {
                case "1":
                    GradeCalculator(); 
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier(); 
                    break;
                case "4":
                    exit = true; 
                    break;
                default:
                    // Handle invalid menu input
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

  
    static void GradeCalculator()
    {
        Console.Write("\nEnter numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine()); 

        // Determine the letter grade based on ranges
        if (grade >= 90)
            Console.WriteLine("Letter Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Letter Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Letter Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Letter Grade: D");
        else
            Console.WriteLine("Letter Grade: F");
    }
    // Function to calculate ticket price based on age
    static void TicketPriceCalculator()
    {
        Console.Write("\nEnter your age: ");
        int age = int.Parse(Console.ReadLine()); 

        // Apply discount pricing logic for children (<=12) or seniors (>=65)
        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7"); 
        else
            Console.WriteLine("Ticket Price: GHC10"); 
    }
    // Function to identify the type of triangle based on side lengths
    static void TriangleTypeIdentifier()
    {
        Console.WriteLine("\nEnter the lengths of the three sides of the triangle:");

        // Read and convert the three sides from user input
        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        // Check triangle type:
        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral"); // All sides equal
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("Triangle Type: Isosceles"); // Two sides equal
        else
            Console.WriteLine("Triangle Type: Scalene"); // All sides different
    }
}


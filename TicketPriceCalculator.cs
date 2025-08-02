using System;

class TicketPriceCalculatorApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Ticket Price Calculator ===");

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        int age;
        bool isValid = int.TryParse(input, out age);

        if (!isValid || age < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
        else
        {
            double ticketPrice;

            if (age <= 12 || age >= 65)
                ticketPrice = 7.0;
            else
                ticketPrice = 10.0;

            Console.WriteLine($"Ticket Price: GHC{ticketPrice:0.00}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

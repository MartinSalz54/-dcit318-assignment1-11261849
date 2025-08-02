using System;

class TriangleTypeIdentifierApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Triangle Type Identifier ===");

        Console.Write("Enter side A: ");
        double a = ReadSide();

        Console.Write("Enter side B: ");
        double b = ReadSide();

        Console.Write("Enter side C: ");
        double c = ReadSide();

        if (IsValidTriangle(a, b, c))
        {
            if (a == b && b == c)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
        else
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static double ReadSide()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double side) && side > 0)
                return side;

            Console.Write("Invalid input. Enter a positive number: ");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}

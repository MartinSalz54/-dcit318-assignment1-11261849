using System;

class GradeCalculatorApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Grade Calculator ===");

        Console.Write("Enter a numerical grade (0 - 100): ");
        string input = Console.ReadLine();

        int grade;
        bool isValid = int.TryParse(input, out grade);

        if (!isValid || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
        else
        {
            string letterGrade;

            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Letter Grade: {letterGrade}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

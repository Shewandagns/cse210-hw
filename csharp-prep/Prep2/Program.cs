using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Determine letter grade
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine pass/fail
        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time.");
        }

        // Determine the sign for the grade
        string sign = "";
        if (letter != "F") // No plus/minus for F
        {
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptional cases for A and F
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Print final grade with sign
        Console.WriteLine($"Your final grade is {letter}{sign}.");
    }
}

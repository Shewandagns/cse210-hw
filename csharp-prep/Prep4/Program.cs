using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        // Input numbers from the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Core requirements
        // Calculate sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Calculate average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find maximum number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenges
        // Find smallest positive number
        int? smallestPositive = numbers.Where(n => n > 0).Min();
        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Sort the list and display
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

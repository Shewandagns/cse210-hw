using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display the results using GetFractionString and GetDecimalValue
        Console.WriteLine(fraction1.GetFractionString()); // Outputs: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Outputs: 1

        Console.WriteLine(fraction2.GetFractionString()); // Outputs: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // Outputs: 5

        Console.WriteLine(fraction3.GetFractionString()); // Outputs: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Outputs: 0.75

        Console.WriteLine(fraction4.GetFractionString()); // Outputs: 1/3
        Console.WriteLine(fraction4.GetDecimalValue());   // Outputs: 0.3333333333333333

        // Using setters and getters
        fraction3.SetNumerator(6);
        fraction3.SetDenominator(7);

        Console.WriteLine(fraction3.GetFractionString()); // Outputs: 6/7
        Console.WriteLine(fraction3.GetDecimalValue());   // Outputs: 0.8571428571428571
    }
}

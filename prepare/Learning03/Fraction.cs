using System;

public class Fraction
{
    // Private attributes
    private int _numerator;
    private int _denominator;

    // Default constructor - initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor for numerator only, denominator is 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor for both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and setter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter and setter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to return the fraction as a string "numerator/denominator"
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

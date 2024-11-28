using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(6);
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");

        // Test updating values using setters
        f3.Top = 7;
        f3.Bottom = 8;
        Console.WriteLine($"Updated Fraction: {f3.GetFractionString()}"); // 7/8
        Console.WriteLine($"Decimal Value: {f3.GetDecimalValue()}"); // 0.875

        // Verify getters
        int numerator = f3.Top;
        int denominator = f3.Bottom;
        Console.WriteLine($"Numerator: {numerator}, Denominator: {denominator}"); // Numerator: 7, Denominator: 8

        // Another test case
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Another Fraction: {f4.GetFractionString()}"); // 1/3
        Console.WriteLine($"Decimal Value: {f4.GetDecimalValue()}"); // 0.333...
    
    }
}
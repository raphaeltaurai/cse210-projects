using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string entry = "";
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (entry != "0")
        {
        Console.Write("Enter number:");
        entry = Console.ReadLine();
        int number = int.Parse(entry);

        numbers.Add(number);
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine($"Total:{numbers.Sum()}");
        Console.WriteLine($"Mean:{numbers.Average()}");

    }
}
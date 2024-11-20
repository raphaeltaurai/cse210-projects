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
        if (int.TryParse(entry, out int number) && number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Total: {sum}");
        Console.WriteLine($"Mean:  {numbers.Average()}");

        int largest = numbers[0]; 

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i]; // Update largest number
            }
        }

        Console.WriteLine($"Largest number: {largest}");
    }
}
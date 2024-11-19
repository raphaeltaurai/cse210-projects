using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "";

        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid percentage");
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratulations you passed the class");
        }
        else
        {
            Console.WriteLine("Sorry you failed the class better luck next semester");
        }
    }
}
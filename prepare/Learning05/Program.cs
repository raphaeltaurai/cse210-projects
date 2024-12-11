using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Calisto Gomez", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        MathAssignment a2 = new MathAssignment("Chiremba Rimuka", "Long Division", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mahuni Tafadzwa", "Home Ecnomics", "Food Storage");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
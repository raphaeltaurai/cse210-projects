using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{ShortName}' progress recorded! You earned {Points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
        => $"[Eternal] {ShortName}: {Description} - Points: {Points}";

    public override string GetStringRepresentation()
        => $"EternalGoal|{ShortName}|{Description}|{Points}";
}

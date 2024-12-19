public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{_shortName}' progress recorded! You earned {_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
        => $"[Eternal] {_shortName}: {_description} - Points: {_points}";

    public override string GetStringRepresentation()
        => $"EternalGoal|{_shortName}|{_description}|{_points}";
}
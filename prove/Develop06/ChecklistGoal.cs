public class ChecklistGoal : Goal
{
    protected int _amountCompleted; // Changed to protected
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points + _bonus} points.");
        }
        else
        {
            Console.WriteLine($"Progress recorded for '{_shortName}'. {_amountCompleted}/{_target} completions.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
        => $"[Checklist] {_shortName}: {_description} - {_amountCompleted}/{_target} - Points: {_points}, Bonus: {_bonus}";

    public override string GetStringRepresentation()
        => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
}
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted => _amountCompleted;
    public int Target => _target;
    public int Bonus => _bonus;

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
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points + _bonus} points.");
        }
        else
        {
            Console.WriteLine($"Progress recorded for '{ShortName}'. {_amountCompleted}/{_target} completions.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
        => $"[Checklist] {ShortName}: {Description} - {_amountCompleted}/{_target} - Points: {Points}, Bonus: {_bonus}";

    public override string GetStringRepresentation()
        => $"ChecklistGoal|{ShortName}|{Description}|{Points}|{_amountCompleted}|{_target}|{_bonus}";
}

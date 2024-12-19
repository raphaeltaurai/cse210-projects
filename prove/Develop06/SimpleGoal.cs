public class SimpleGoal : Goal
{
    protected bool _isComplete; // Changed to protected

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
        => $"[Simple] {_shortName}: {_description} - Points: {_points} - Completed: {IsComplete()}";

    public override string GetStringRepresentation()
        => $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
        }
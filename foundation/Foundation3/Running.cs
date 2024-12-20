public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; 
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {GetDistance()} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
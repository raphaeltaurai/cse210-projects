public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Distance in miles (50 meters per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
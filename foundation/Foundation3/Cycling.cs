public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60; 
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        return 60 / GetSpeed(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
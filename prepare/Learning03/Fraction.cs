using System.ComponentModel.DataAnnotations;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for _top
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    // Getter and Setter for _bottom
    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double quotient = (double)_top / (double)_bottom;
        return Math.Round(quotient, 8);
    }

}
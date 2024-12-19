public abstract class Shape
{

    public Shape(string color)
    {
        SetColor(color);
    }
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    

    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    public abstract double GetArea();
}
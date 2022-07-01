namespace Prn.Se1624;
public class Circle : Shape
{
    private double _radius;

    public Circle() { }
    public Circle(double radius)
    {
        this._radius = radius;
    }
    public Circle(double radius, string color) : base(color)
    {
        this._radius = radius;
    }
    //Expression-bodied
    public double Radius { get => _radius; set => _radius = value; }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double GetPerimetter()
    {
        return Math.PI * 2 * this._radius;
    }

    public override string? ToString()
    {
        return $"The circle radius = {Radius}, the area = {GetArea()}, the perimetter = {GetPerimetter()}";
    }
}
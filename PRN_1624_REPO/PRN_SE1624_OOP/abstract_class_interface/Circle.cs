namespace Prn.Se1624;
public class Circle : Shape
{
    private double _radius;


    public Circle() { }
    public Circle(double radius)
    {
        this._radius = radius;
    }
    public Circle(double radius, string color):base(color)
    {
        
        this._radius = radius;
        
    }
    //Expression-bodied
    public double Radius { get => _radius; set => _radius = value; }

    public override double GetArea() => Math.PI*Math.Pow(Radius, 2);

    public override double GetPerimetter() => 2 * Math.PI * this._radius;

    public override string? ToString() => $"The circle has radius = {Radius}, Area = {GetArea()}, Perimetter = {GetPerimetter()} and Color = {Color}";

    public override void Display()
    {
        Console.WriteLine("abc");
    }
}
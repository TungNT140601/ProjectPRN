namespace Prn.Se1624;
public abstract class Shape
{
    public Shape()
    {

    }
    public Shape(string color)
    {
        Color = color;  
    }
    public string Color { get; set; }

    public abstract double GetArea();
    public abstract double GetPerimetter();

    public virtual void Display()
    {
        Console.WriteLine($"Color is: {Color}");
    }
}
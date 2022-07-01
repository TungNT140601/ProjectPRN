namespace Prn.Se1624;
public class Rectangle:IShape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle() { }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double GetArea()
    {
        return Height * Width;
    }

    public double GetPerimetter()
    {
        return (Height + Width) * 2;
    }
}
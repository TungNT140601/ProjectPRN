using System;
namespace Fpteud.Se1624; //.NET 6
public class Programming
{
    public static void Main(string[] args)
    {
        int x = 10, y = 20, z = 30;
        DemoRef.MyMethod(x,ref y,out z);

        Console.WriteLine($"x ={x}, y ={y} and z={z}");

    }

    public static int Sum(int a, int b)
    {
        return a + b;   
    }
}


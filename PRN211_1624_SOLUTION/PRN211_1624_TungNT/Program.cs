using System;  //khai báo thư viện

//namespace được dùng để tổ chức các lớp
namespace Fptedu.Se1624; // .NET 6

public class Programming
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Tung");
        int x = 10, y = 20;
        var name = "Abc";
        var agev = 21.5;

        dynamic age;
        age = 22;
        Console.WriteLine(age);
        age = "hai hai";
        
        Console.WriteLine("Kieu du lieu cua agev la : {0}",agev.GetType().Name);
        Console.WriteLine(name.GetType().Name);

        Console.WriteLine(age);


        Console.WriteLine($"Total of x = {x} and y = {y} is: {Sum(x,y)}");

        Console.ReadLine();
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

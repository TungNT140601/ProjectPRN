namespace Test;
class MyClass
{
    public static int x = 1;
    static MyClass()
    {
        x = 2;
        Console.WriteLine("Static contructor : x={0}", x);
    }
    public MyClass()
    {
        x++;
        Console.WriteLine("Object contructor : x={0}", x);
    }
}
static class Utils
{
    public static int Add(int a, int b) { return a + b; }
    public static int Sub(this int a, int b) { return a - b; }
}
public class TestTu
{
    static int[] number = { 1, 2, 3, 4, 5, };
    public static void Main(string[] args)
    {
        /*Console.WriteLine($"Input number: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < number.Length; i++)
        {
            if (a == number[i])
            {
                number[i] = number[i] * 2;
            }
        }
        Console.WriteLine(string.Join(" ", number));*/


        /*MyClass m1 = new MyClass();
        MyClass.x = 4;
        MyClass m2 = new MyClass();*/

        /*int x = 3, y = 2;
        int r = Utils.Add(x, y);
        Console.WriteLine("{0}+{1}={2}", x, y, r);
        r = x.Sub(y);
        Console.WriteLine($"{x}-{y}={r}");
        Console.ReadLine();*/


        /*var obj1 = new { name = "Tung", age = 21, email = "tungnt14062001@gmail.com" };
        Console.WriteLine($"name: {obj1.name}");*/


        try
        {
            using var reader = new System.IO.StreamReader(@"D:\");
            var content = reader.ReadToEnd();
            Console.WriteLine($"File length: {content.Length}");
        }
        catch (System.IO.IOException)
        {

        }
    }
}
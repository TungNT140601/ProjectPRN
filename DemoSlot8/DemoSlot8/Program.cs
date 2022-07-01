using System.Collections;

namespace Slot8;
class DemoSlot8
{
    static void Main(string[] args)
    {
        int s = 0, number;
        IntCollection collection = new IntCollection();

        collection.AddInt(10);
        collection.AddInt(20);
        collection.AddInt(30);
        for (int i = 0; i < collection.Count(); i++)
        {
            number = collection.GetInt(i);
            s += number;
            Console.Write($"{number}" + $"{(i == collection.Count() - 1 ? " = " : " + ")}");
        }

        Console.WriteLine($"{s}");

        Console.WriteLine("-----------------------------------------------------------------------------------");

        int a = 10;
        ArrayList data = new ArrayList();
        data.Add(a);

        int b = (int)data[0];
        Console.WriteLine(b);

        Console.WriteLine("-----------------------------------------------------------------------------------");

        MyClass<string> obj1 = new MyClass<string>()
        {
            Value = "Jack"
        };
        Console.WriteLine(obj1);
        MyClass<float> obj2 = new MyClass<float>()
        {
            Value = 0.55f
        };
        Console.WriteLine(obj2);

        dynamic obj = new { Id = 1, data = "Tung" };

        MyClass<dynamic> obj3 = new MyClass<dynamic>()
        {
            Value = obj
        };
        Console.WriteLine(obj3);
        Console.ReadLine();

        Console.WriteLine("-----------------------------------------------------------------------------------");

        MyClass1 myClass1 = new MyClass1();
        myClass1.Display<string, int>("Integer", 2050);
        myClass1.Display<double, char>(159.5, 'A');
        myClass1.Display<float, double>(353f, 12312.123);
        Console.ReadLine();

        Console.WriteLine("-----------------------------------------------------------------------------------");


    }

    public class MyClass1
    {
        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine(msg.GetType() + ", " + value.GetType());
        }
    }
}
namespace Fpteud.Se1624;
public class DemoRef
{
    public static void MyMethod(int a, ref int b, out int c)
    {
        a = 1;
        b = 2;
        c = 3;
        
    }
}
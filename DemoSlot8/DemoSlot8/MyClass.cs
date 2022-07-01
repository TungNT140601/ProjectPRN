namespace Slot8;
public class MyClass<T>
{
    private T data;
    public T Value
    {
        get => data;
        set => data = value;
    }

    public override string? ToString() => $"Value: {data}";
}
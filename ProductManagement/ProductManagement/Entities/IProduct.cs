namespace Prn.Se1624;
public interface IProduct
{
    void Add(Product p);
    void Remove(Product p);
    bool Update(Product p);
    Product Get(int index);
    void Display();

}
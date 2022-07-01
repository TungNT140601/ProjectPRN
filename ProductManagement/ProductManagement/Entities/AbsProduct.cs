namespace Prn.Se1624;
public abstract class AbsProduct
{
    protected Product[] products;

    protected int size;
    //public Product[] products { get; }
    //public int Size { get; }
    public AbsProduct()
    {
        this.products = new Product[Utils.InitNumberProduct];
        this.size = 0;
    }
}

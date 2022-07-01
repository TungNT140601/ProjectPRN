namespace Prn.Se1624;

public abstract class AbsProduct
{
    protected Product[] products;

    protected int size;
    public AbsProduct()
    {
        this.products = new Product[Utils.InitNumberProduct];
        this.size = 0;
    }
}
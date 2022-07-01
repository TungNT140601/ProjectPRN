namespace Prn.Se1624;
public class ProductManagement : AbsProduct, IProduct
{
    public ProductManagement()
    {

    }
    public void Add(Product p)
    {
        if (this.size >= this.products.Length)
        {
            Product[] temp = new Product[this.products.Length * 2];
            for (int i = 0; i < this.products.Length; i++)
            {
                temp[i] = this.products[i];
            }
            this.products[this.size] = p;
            this.size++;
        }
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public Product Get(int index)
    {
        throw new NotImplementedException();
    }

    public void Remove(Product p)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}
namespace PrnSe1624;
public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public double? UnitPrice { get; set; }

    public Product()
    {
    }

    public Product(int productId, string? productName, double? unitPrice)
    {
        ProductId = productId;
        ProductName = productName;
        UnitPrice = unitPrice;
    }

    public override string? ToString() 
        => $"[ProductID: {ProductId}, ProductName: {ProductName}, UnitPrice: {UnitPrice}]";
}
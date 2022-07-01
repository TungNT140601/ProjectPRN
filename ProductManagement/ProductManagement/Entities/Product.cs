namespace Prn.Se1624;
public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public string? Desc { get; set; }
    public double UnitPrice { get; set; }
    public DateTime? createDate { get; set; }

    public Product()
    {
    }

    public Product(int id, string? productName, string? desc, double unitPrice, DateTime? createDate)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        this.createDate = createDate;
    }

    public override string? ToString() => $"[Id = {Id},Name = {ProductName},Price = {UnitPrice},Desc = {Desc},Date = {createDate}]";
}

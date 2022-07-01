namespace Prn.Se1624;
public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public string? Desc { get; set; }
    public double UnitPrice { get; set; }
    public DateTime? CreatedDate { get; set; }

    public Product() { }

    public Product(int id, string? productName, string? desc, double unitPrice, DateTime? createdDate)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        CreatedDate = createdDate;
    }
    //Expression-Bodied
    public override string? ToString() => $"[ID = {Id}, Product Name ={ProductName}, Unit Price = {UnitPrice}, Date = {CreatedDate}]";
}
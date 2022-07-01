using Prn.Se1624;
using static System.Console;

ProductManagement productManagement = new ProductManagement();
Product p = new Product(1,"Dell 15inch","Dell moi nhat nam 2022",1520d, new DateTime(year:2022, month: 5, day: 22));

productManagement.Add(p);
productManagement.Add(new Product(2,"Macbook pro 2021","Macbook xin nhat",2500d,DateTime.Now));

productManagement.Add(new Product(3, "Macbook pro 2022", "Macbook xin nhat", 2500d, DateTime.Now));
productManagement.Add(new Product(4, "Macbook pro 2023", "Macbook xin nhat", 4500d, DateTime.Now));

productManagement.Display();


ReadLine(); 
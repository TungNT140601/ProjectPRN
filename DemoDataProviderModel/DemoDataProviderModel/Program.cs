namespace PrnSe1624;
using System;
using System.IO;
using System.Data.Common;//ADO.NET
using Microsoft.Data.SqlClient;//Tao trinh dieu khien tuong tac sql sever
using Microsoft.Extensions.Configuration;
public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetConnectionString());
        IEnumerable<Product>? products = GetAllProduct();
        foreach(Product p in products)
        {
            Console.WriteLine(p.ToString());
        }
        Console.ReadLine();
    }

    //read data from AppSetting.json

    private static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSetting.json",true,true)
            .Build();


        return config["ConnectionString:FPT_EduDB"];
    }
    public static List<Product>? GetAllProduct()
    {
        List<Product>? products = new List<Product>();
        string vSQL = "SELECT * FROM [FPT_Edu].[dbo].[Products]";

        //1. Init providers
        DbProviderFactory factory = SqlClientFactory.Instance;

        //2. Init connection to database SQL sever
        DbConnection? conn = factory.CreateConnection();
        try
        {
            if (conn is null)
            {
                Console.WriteLine("Init Connection Fail.....");
                return null;
            }
            conn.ConnectionString = GetConnectionString();
            conn.Open();

            //3. execute command (sql)
            using DbCommand cmd = conn.CreateCommand();
            if (cmd is null)
            {
                Console.WriteLine("Init Connection Fail.....(cmd)");
                return null;
            }
            cmd.CommandText = vSQL;
            cmd.Connection = conn;
            //4. read data from command
            using DbDataReader? reader = cmd.ExecuteReader();

            //5. add to list and return
            if (reader != null && reader.HasRows)
            {
                while (reader.Read())
                {
                    Product p = new Product();
                    p.ProductId = (int)reader["ProductId"];
                    p.ProductName = (string)reader["ProductName"];
                    //p.UnitPrice = (decimal)reader["UnitPrice"];
                    p.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    products.Add(p);
                }
            }
            
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            
        }
        return products;
    }
}
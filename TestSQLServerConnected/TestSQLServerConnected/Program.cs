namespace DemoSql;
using System;
using System.IO;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public class Program
{
    private static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSetting.json", true, true)
            .Build();

        return config["ConnectionString : FPT_Edu"];
    }

    private static void ViewProduct()
    {
        DbProviderFactory factory = SqlClientFactory.Instance;

        using DbConnection? connection = factory.CreateConnection();
        if (connection == null)
        {
            Console.WriteLine($"Unable to create the connection object.");
            return;
        }
        connection.ConnectionString = GetConnectionString();
        connection.Open();

        DbCommand command = factory.CreateCommand();
        if (command == null)
        {
            Console.WriteLine($"Unable to create the command object.");
            return;
        }
        command.Connection = connection;
        command.CommandText = "Select ProductID,ProductName From Products";

        using DbDataReader dataReader = command.ExecuteReader();
        Console.WriteLine("***********Product List***********");
        while (dataReader.Read())
        {
            Console.WriteLine($"ProductID: {dataReader["ProductID"]}, ProductName: {dataReader["ProductName"]}.");
        }
    }

    public static void Main()
    {
        ViewProduct();
        Console.ReadLine();
    }
}

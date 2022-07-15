﻿using System.IO;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);
        }
        //----------------------------------------------------------
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSetting.json", true, true)
                .Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }
        //----------------------------------------------------------
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}

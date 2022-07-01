using System;
using System.Collections.Generic;

namespace DemoDatabaseFist.EntitiesModels
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}

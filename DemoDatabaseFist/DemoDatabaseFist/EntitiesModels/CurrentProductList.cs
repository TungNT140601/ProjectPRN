using System;
using System.Collections.Generic;

namespace DemoDatabaseFist.EntitiesModels
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}

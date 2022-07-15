using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BussinessObject.Models
{
    public partial class FStoreContext : DbContext
    {
        public FStoreContext(string conn)
        {
            this.Database.SetConnectionString(conn);
        }
    }
}

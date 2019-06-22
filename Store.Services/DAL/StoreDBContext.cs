using Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Services.DAL
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext()
            : base("name=StoreDBContext")
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
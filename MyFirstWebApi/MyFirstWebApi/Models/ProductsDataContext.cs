using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstWebApi.Models
{
    public class ProductsDataContext:DbContext 
    {
        public DbSet<Product> Product { get; set; }
    }
}
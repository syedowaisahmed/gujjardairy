using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    public class ProductDbContext: IdentityDbContext
    {
        public DbSet<ProductCategoryBindingModel> Products { get; set; }
        public DbSet<ProductCategoryBindingModel> ProductCategories { get; set; }
        public DbSet<ProductCategoryBindingModel> ProductItems { get; set; }
        public DbSet<ProductCategoryBindingModel> WebsiteProducts { get; set; }
    }
}
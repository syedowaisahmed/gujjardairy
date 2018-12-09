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
        public DbSet<ProductBindingModel> Products { get; set; }
        public DbSet<ProductCategoryBindingModel> ProductCategories { get; set; }
        public DbSet<ProductItemBindingModel> ProductItems { get; set; }
        public DbSet<WebsiteProductBindingModel> WebsiteProducts { get; set; }
    }
}
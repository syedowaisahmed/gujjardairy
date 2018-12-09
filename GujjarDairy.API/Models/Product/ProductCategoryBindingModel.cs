using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    [Table("ProductCategories")]
    public class ProductCategoryBindingModel
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
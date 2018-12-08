using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    public class ProductCategoryBindingModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Name { get; set; }
        public int Status { get; set; }
    }
}
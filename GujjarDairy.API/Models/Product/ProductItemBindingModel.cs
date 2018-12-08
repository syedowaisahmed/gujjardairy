using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    public class ProductItemBindingModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal BasePrice { get; set; }
        public bool Optional { get; set; }
        public string Status { get; set; }
        public int ProductId { get; set; }
        public ProductBindingModel Product { get; set; }
    }
}
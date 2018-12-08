using GujjarDairy.API.Models.Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    public class WebsiteProductBindingModel
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public int ProductId { get; set; }
        public WebsiteBindingModel Website { get; set; }
        public ProductBindingModel Product { get; set; }
    }
}
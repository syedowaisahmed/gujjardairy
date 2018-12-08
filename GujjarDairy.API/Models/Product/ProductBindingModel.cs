﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Product
{
    public class ProductBindingModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategoryBindingModel ProductCategory { get; set; }
    }
}
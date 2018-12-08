using GujjarDairy.API.Models.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GujjarDairy.API.Models.Website
{
    public class WebsiteBindingModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ApplicationId { get; set; }
        public ApplicationBindingModel Application { get; set; }
    }
}
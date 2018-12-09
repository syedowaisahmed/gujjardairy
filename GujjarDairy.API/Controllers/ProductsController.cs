using GujjarDairy.API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace GujjarDairy.API.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : BaseApiController
    {   
        [Authorize]
        [Route("productcategories")]
        public IHttpActionResult GetProductCategories()
        {
            using (var context = new ProductDbContext())
            {
                return Ok(context.ProductCategories.ToList());
            }
        }
    }
}
using MyFirstWebApi.Business;
using MyFirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private ProductBusiness _ProductBusiness = new ProductBusiness();
        [Route("GetProducts")]
        public IHttpActionResult GetProducts() {
            var products = _ProductBusiness.GetProducts();
            return Ok(products);
        }
        [Route("GetProduct/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            if (id == 0)
            {
                return BadRequest("Product ID must be non zero number!");
            }
            var product = _ProductBusiness.GetProduct(id);
            return Ok(product);
        }
        [Route("Create")]
        public IHttpActionResult Create(Product product)
        {
            if (product == null)
                return BadRequest();
            return Ok(_ProductBusiness.Create(product));
        }
    }
}

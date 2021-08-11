using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Business.Abstract;

namespace ECommerce.Api.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("api/[controller]/GetProduct")]
        public IActionResult GetProduct()
        {
            var products = _productService.GetProducts();

            return Ok(products);
        }
    }
}

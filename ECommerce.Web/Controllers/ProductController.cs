using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ECommerce.Web.Abstract;

namespace ECommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        public async Task<IActionResult> Index()
        {
            var products =await  _productBusiness.GetProductsFromApi();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(products);
        }
    }
}

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
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        [Route("api/[controller]/GetBasket")]
        public IActionResult GetBasketByUserId(Guid userId)
        {
            var baskets = _basketService.GetBaskets(userId);

            return Ok(baskets);
        }
    }
}

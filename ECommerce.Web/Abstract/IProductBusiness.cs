using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Web.Models;

namespace ECommerce.Web.Abstract
{
    public interface IProductBusiness
    {
        Task<List<ProductModel>> GetProductsFromApi();
    }
}

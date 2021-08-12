using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Web.Abstract;
using ECommerce.Web.ApiHelper;
using ECommerce.Web.Models;

namespace ECommerce.Web.Concrete
{
    public class ProductBusiness:IProductBusiness
    {
        private readonly IRestApiGenerator _restApiGenerator;

        public ProductBusiness(IRestApiGenerator restApiGenerator)
        {
            _restApiGenerator = restApiGenerator;
        }

        public async Task<List<ProductModel>> GetProductsFromApi()
        {
            string url = "http://localhost:34284/api/Product/GetProduct";
            var products = await _restApiGenerator.GetApi<List<ProductModel>>(url);

            return products;
        }
    }
}

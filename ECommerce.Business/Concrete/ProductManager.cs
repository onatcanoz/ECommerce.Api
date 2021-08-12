using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities;

namespace ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProducts()
        {
           return _productDal.GetAll();
        }

        public void CreateProduct(Product product)
        {
            _productDal.Create(product);
        }

        public void UpdateProduct(Product product)
        {
            _productDal.Update(product);
        }

        public void DeleteProduct(Product product)
        {
            _productDal.Delete(product);
        }
    }
}

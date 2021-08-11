using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entities;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}

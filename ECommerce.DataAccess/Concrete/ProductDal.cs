using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Concrete
{
    public class ProductDal : GenericRepository<Product, ApplicationDbContext>, IProductDal
    {
        private ApplicationDbContext _db;

        public ProductDal(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}

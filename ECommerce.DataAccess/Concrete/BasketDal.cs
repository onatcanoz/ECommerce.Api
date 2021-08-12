using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.Entities;

namespace ECommerce.DataAccess.Concrete
{
    public class BasketDal : GenericRepository<Basket, ApplicationDbContext>, IBasketDal
    {
        private ApplicationDbContext _db;

        public BasketDal(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}

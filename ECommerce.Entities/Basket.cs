using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Basket
    {
        public int Id { get; set; }

        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }
        public Guid UserId { get; set; }
        public List<Product> Products { get; set; }
    }
}

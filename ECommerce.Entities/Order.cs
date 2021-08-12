using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderedBy { get; set; }
        public int TotalPrice { get; set; }

        public List<Product> Products { get; set; }
    }
}

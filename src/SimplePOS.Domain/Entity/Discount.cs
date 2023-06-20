using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class Discount
    {
        public string Name { get; set; }
        public decimal DiscountPrice { get; set; }
        public List<Product> Products { get; set; }
    }
}

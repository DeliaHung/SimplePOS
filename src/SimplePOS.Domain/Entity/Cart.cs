using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Discount> AppliedDiscounts { get; set; } = new List<Discount>();
        
        public decimal TotalPrice = 0;

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            Products.Add(product);
        }
    }
}

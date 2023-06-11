using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();
        
        public List<DiscountRuleBase> DiscountRules { get; set; } = new List<DiscountRuleBase>();
        
        public decimal TotalPrice = 0;

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            Products.Add(product);
        }

        public void AddDiscountRule(DiscountRuleBase discountRule)
        {
            if (discountRule == null)
            {
                throw new ArgumentNullException(nameof(discountRule));
            }

            DiscountRules.Add(discountRule);
        }
    }
}

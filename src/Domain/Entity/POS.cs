using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class POS
    {
        private readonly List<DiscountRule> _discountRules;

        public POS(List<DiscountRule> discountRules)
        {
            _discountRules = discountRules;
        }

        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddDiscountRule(DiscountRule discountRule)
        {
            if (discountRule == null)
            {
                throw new ArgumentNullException(nameof(discountRule));
            }
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            Products.Add(product);
        }

        public decimal CaculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}

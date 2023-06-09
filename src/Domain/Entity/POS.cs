using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class POS
    {
        private readonly List<DiscountRuleBase> _discountRules = new List<DiscountRuleBase>();

        public POS(List<DiscountRuleBase> discountRules)
        {
            _discountRules = discountRules;
        }

        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddDiscountRule(DiscountRuleBase discountRule)
        {
            if (discountRule == null)
            {
                throw new ArgumentNullException(nameof(discountRule));
            }

            _discountRules.Add(discountRule);
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
            
            
            foreach (var discountRule in _discountRules)
            {
                totalPrice -= discountRule.Process(Products);
            }

            return totalPrice;
        }
    }
}

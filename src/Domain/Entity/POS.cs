using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class POS
    {
        public List<DiscountRuleBase> DiscountRules { get; set; } = new List<DiscountRuleBase>();

        public POS() { }

        public Cart CheckOut(Cart cart)
        {
            cart.TotalPrice = cart.Products.Select(p => p.SalePrice).Sum();

            foreach (var rule in DiscountRules) 
            {
                var discount =  rule.Process(cart);
                cart.TotalPrice -= discount.DiscountPrice;
                cart.Discount.Add(discount);
            }

            return cart;
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

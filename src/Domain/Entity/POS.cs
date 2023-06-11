using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public class POS
    {
        public POS() { }

        public Cart CaculateTotalPrice(Cart cart)
        {
            cart.TotalPrice = cart.Products.Select(p => p.Price).Sum();

            foreach (var rule in cart.DiscountRules) 
            {
                var discount =  rule.Process(cart);
                cart.TotalPrice -= discount;
            }

            return cart;
        }
    }
}

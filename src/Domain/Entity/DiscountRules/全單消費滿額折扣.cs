using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity.DiscountRules
{
    public class 全單消費滿額折扣 : DiscountRuleBase
    {
        private readonly int _minPrice;
        private readonly int _discountPrice;

        public 全單消費滿額折扣(int minPrice, int discountPrice)
        {
            _minPrice = minPrice;
            _discountPrice = discountPrice;
        }

        public override decimal Process(Cart cart)
        {
            if (cart.TotalPrice >= _minPrice)
            {
                return _discountPrice;
            }

            return 0;
        }
    }
}

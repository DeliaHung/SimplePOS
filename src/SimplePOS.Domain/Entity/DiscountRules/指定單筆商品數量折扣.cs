using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity.DiscountRules
{
    public class 指定單筆商品數量折扣 : DiscountRuleBase
    {
        private readonly int _productId;
        private readonly int _quantity;
        private readonly decimal _discountPrice;

        public 指定單筆商品數量折扣(int productId, int quantity, decimal discountPrice)
        {
            _productId = productId;
            _quantity = quantity;
            _discountPrice = discountPrice;
        }

        public override Discount Process(Cart cart)
        {
            Discount discount = new Discount();
            var quantity = cart.Products.Count(_ => _.Id == _productId);

            if (quantity < _quantity)
            {
                return null;
            }
            else
            {
                discount.DiscountPrice = _discountPrice;
                return discount;
            }

        }
    }
}

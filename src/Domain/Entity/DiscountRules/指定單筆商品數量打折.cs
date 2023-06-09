using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity.DiscountRules
{
    public class 指定單筆商品數量打折 : DiscountRuleBase
    {
        private readonly int _productId;
        private readonly int _quantity;
        private readonly decimal _discountPrice;

        public 指定單筆商品數量打折(int productId, int quantity, decimal discountPrice)
        {
            _productId = productId;
            _quantity = quantity;
            _discountPrice = discountPrice;
        }

        public override decimal Process(List<Product> products)
        {
            var quantity = products.Count(_ => _.Id == _productId);

            if (quantity < _quantity)
            {
                return 0;
            }
            else
            {
                return _discountPrice;
            }

        }
    }
}

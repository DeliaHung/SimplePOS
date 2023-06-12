using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public abstract class DiscountRuleBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RuleType RuleType { get; set; }
        public abstract Discount Process(Cart cart);
    }

    public enum RuleType
    { 
        OrderWide,
        ProductWide
    }

    public abstract class OrderWideDiscount : DiscountRuleBase
    {
        public OrderWideDiscount()
        {
            RuleType = RuleType.OrderWide;
        }
    }

    public abstract class ProductWideDiscount : DiscountRuleBase
    {
        public ProductWideDiscount()
        {
            RuleType = RuleType.ProductWide;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public abstract class DiscountRuleBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public abstract decimal Process(Cart cart);
    }
}

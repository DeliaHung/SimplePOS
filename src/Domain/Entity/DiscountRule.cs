using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Domain.Entity
{
    public abstract class DiscountRule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        protected abstract decimal Process(List<Product> products);
    }
}

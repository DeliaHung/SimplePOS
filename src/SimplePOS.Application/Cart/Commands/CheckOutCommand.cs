using MediatR;
using SimplePOS.Domain.Entity.DiscountRules;
using SimplePOS.Domain.Entity;

namespace SimplePOS.Application.Cart.Commands
{
    public class CheckOutCommand : IRequest<Domain.Entity.Cart>
    {

    }

    public class CheckOutCommandHandler : IRequestHandler<CheckOutCommand, Domain.Entity.Cart>
    {
        public async Task<Domain.Entity.Cart> Handle(CheckOutCommand request, CancellationToken cancellationToken)
        {
            POS pos = new POS();
            pos.AddDiscountRule(new 指定單筆商品數量折扣(1, 2, 10));
            pos.AddDiscountRule(new 全單消費滿額折扣(100, 10));

            Domain.Entity.Cart cart = new ();
            cart.AddProduct(new Product { Id = 1, Name = "百香綠茶", SalePrice = 40 });
            cart.AddProduct(new Product { Id = 1, Name = "百香綠茶", SalePrice = 40 });
            cart.AddProduct(new Product { Id = 3, Name = "烏龍拿鐵", SalePrice = 65 });
            
            pos.CheckOut(cart);

            return cart;
        }
    }
}

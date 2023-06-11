using SimplePOS.Domain.Entity;
using SimplePOS.Domain.Entity.DiscountRules;

POS pos = new POS();
Cart cart = new Cart();
cart.AddProduct(new Product { Id = 1, Name = "百香綠茶", Price = 40 });
cart.AddProduct(new Product { Id = 1, Name = "百香綠茶", Price = 40 });
cart.AddProduct(new Product { Id = 3, Name = "烏龍拿鐵", Price = 65 });

cart.AddDiscountRule(new 指定單筆商品數量折扣(1, 2, 10));
cart.AddDiscountRule(new 全單消費滿額折扣(100, 10));

pos.CaculateTotalPrice(cart);

foreach (var product in cart.Products)
{
    Console.WriteLine(product.ToString());
}
Console.WriteLine("-----------------------------");
Console.WriteLine("總額:"+ cart.TotalPrice.ToString());
Console.ReadLine();
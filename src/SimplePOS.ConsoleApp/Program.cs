using SimplePOS.Domain.Entity;
using SimplePOS.Domain.Entity.DiscountRules;

POS pos = new(new List<DiscountRuleBase>());
pos.AddProduct(new Product { Id = 1, Name = "百香綠茶", Price = 40 });
pos.AddProduct(new Product { Id = 1, Name = "百香綠茶", Price = 40 });
pos.AddProduct(new Product { Id = 3, Name = "烏龍拿鐵", Price = 65 });

pos.AddDiscountRule(new 指定單筆商品數量打折(1, 2, 10));

var totalPrice = pos.CaculateTotalPrice();

foreach (var product in pos.Products)
{
    Console.WriteLine(product.ToString());
}
Console.WriteLine("-----------------------------");
Console.WriteLine("總額:"+ totalPrice.ToString());
Console.ReadLine();
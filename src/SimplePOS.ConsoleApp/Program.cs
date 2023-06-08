using SimplePOS.Domain.Entity;

POS pos = new(new List<DiscountRule>());
pos.AddProduct(new Product { Id = 1, Name = "百香綠茶", Price = 40 });
pos.AddProduct(new Product { Id = 1, Name = "紅茶拿鐵", Price = 60 });
pos.AddProduct(new Product { Id = 1, Name = "烏龍拿鐵", Price = 65 });
var totalPrice = pos.CaculateTotalPrice();
Console.WriteLine(totalPrice.ToString());
Console.ReadLine();
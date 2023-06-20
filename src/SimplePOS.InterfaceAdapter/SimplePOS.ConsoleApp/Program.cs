using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SimplePOS.Application;
using SimplePOS.Application.Cart.Commands;
using System.Reflection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddApplication();
var serviceProvider = serviceCollection.BuildServiceProvider();
var mediator = serviceProvider.GetRequiredService<IMediator>();
var cart = await mediator.Send(new CheckOutCommand());

foreach (var product in cart.Products)
{
    Console.WriteLine($"{product.Name}。。。{product.SalePrice}元");
}

foreach (var rule in cart.AppliedDiscounts)
{
    Console.WriteLine($"符合折扣規則:{rule.Name}。。。-{rule.DiscountPrice}");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("總額:"+ cart.TotalPrice.ToString());
Console.ReadLine();
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SimplePOS.Application.Cart.Commands;
using System.Reflection;

var serviceCollection = new ServiceCollection()
    .AddMediatR(Assembly.GetExecutingAssembly())
    .BuildServiceProvider();

var mediator = serviceCollection.GetRequiredService<IMediator>();
var cart = await mediator.Send(new CheckOutCommand());

foreach (var product in cart.Products)
{
    Console.WriteLine(product.ToString());
}

Console.WriteLine("-----------------------------");
Console.WriteLine("總額:"+ cart.TotalPrice.ToString());
Console.ReadLine();
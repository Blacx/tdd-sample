using Microsoft.Extensions.DependencyInjection;
using MyConsoleApp.Contracts;
using MyConsoleApp.Helpers;
using MyConsoleApp.Helpers.Calculators;
using MyConsoleApp.Helpers.Discounts;
using MyConsoleApp.Models;
using System;

namespace MyConsoleApp
{
	class Program
	{

		static void Main(string[] args)
		{
			// Initialize .NET Core DI
			var serviceProvider = new ServiceCollection()
				.AddSingleton<ICart, ShoppingCart>()
				.AddSingleton<ICalculator, LinqCalculator>()
				.AddSingleton<IDiscountHelper, DefaultDiscountHelper>()
				.BuildServiceProvider();
			

			// Main App
			Product[] products = {
				new Product {Name = "Fried Rice", Category = "Food", Price = 7.5M},
				new Product {Name = "Burger", Category = "Food", Price = 20M},
				new Product {Name = "Mineral Water", Category = "Drink", Price = 1.5M},
				new Product {Name = "Ice Lemon", Category = "Drink", Price = 2.5M}
			};
			// Inject and Get Cart to Console Main
			var cart = serviceProvider.GetService<ICart>();
			cart.Products = products;

			// Output
			Console.WriteLine(cart.CalculateProductTotal());
			Console.ReadLine();
		}
	}
}

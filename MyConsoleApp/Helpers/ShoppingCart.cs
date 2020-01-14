using MyConsoleApp.Contracts;
using MyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Helpers
{
	/// <summary>
	/// Shoping Cart
	/// </summary>
	public class ShoppingCart : ICart
	{
		private ICalculator _calc;
		public ShoppingCart(ICalculator calc)
		{
			_calc = calc;
		}
		public IEnumerable<Product> Products { get; set; }
		
		/// <summary>
		/// Calculate Total Products
		/// </summary>
		/// <returns></returns>
		public decimal CalculateProductTotal()
		{
			return _calc.ValueProducts(Products);
		}
	}
}

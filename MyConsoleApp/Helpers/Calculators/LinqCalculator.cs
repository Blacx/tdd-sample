using MyConsoleApp.Contracts;
using MyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyConsoleApp.Helpers.Calculators
{
	/// <summary>
	/// Calculate Product using LINQ
	/// </summary>
	public class LinqCalculator : ICalculator
	{
		private IDiscountHelper _discounter;

		public LinqCalculator(IDiscountHelper discounter)
		{
			_discounter = discounter;
		}

		/// <summary>
		/// Calculate Product Price with Discount applied
		/// </summary>
		/// <param name="products">Product list</param>
		/// <returns>Total product after discount applied</returns>
		public decimal ValueProducts(IEnumerable<Product> products)
		{
			var totalProducts = products.Sum(p => p.Price);
			// Apply discount here
			var discount = _discounter.ApplyDiscount(totalProducts);
			return totalProducts - discount;
		}
	}
}

using MyConsoleApp.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Helpers.Discounts
{
	/// <summary>
	/// Default Discount Helper
	/// </summary>
	public class DefaultDiscountHelper : IDiscountHelper
	{
		// Won't use it
		// Can set using some scenario(NINJECT)
		// - Inject from DI contructor argument
		// - Inject with Property value below
		public decimal DiscountSize { get; set; }

		/// <summary>
		/// Apply Default Discount (10%)
		/// </summary>
		/// <param name="total">Total order</param>
		/// <returns>Total order after dicount applied</returns>
		public decimal ApplyDiscount(decimal total)
		{
			// Get flexible discount 
			// return (this.DiscountSize / 100m * total);
			
			// Default discount calculation (10%)
			// Change the percentage to other than 10 to understand what is test case for!
			return ((10m / 100m) * total);
		}
	}
}

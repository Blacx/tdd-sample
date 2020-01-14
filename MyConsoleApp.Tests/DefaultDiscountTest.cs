using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleApp.Contracts;
using MyConsoleApp.Helpers.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Tests
{
	[TestClass]
	public class DefaultDiscountTest
	{

		private IDiscountHelper getTestObject()
		{
			return new DefaultDiscountHelper();
		}

		[TestMethod]
		public void Ten_Percent_Default_Discount()
		{			
			// arrange
			IDiscountHelper target = getTestObject();
			decimal total = 200;
			// act
			var discountedTotal = target.ApplyDiscount(total);
			// assert
			Assert.AreEqual(180, discountedTotal);
		}
	}
}

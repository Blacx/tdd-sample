using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Contracts
{
	public interface IDiscountHelper
	{
		decimal ApplyDiscount(decimal total);
	}
}

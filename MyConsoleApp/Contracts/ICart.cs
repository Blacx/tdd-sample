using MyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Contracts
{
	public interface ICart
	{
		IEnumerable<Product> Products { get; set; }
		decimal CalculateProductTotal();
	}
}

using MyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Contracts
{
	public interface ICalculator
	{
		decimal ValueProducts(IEnumerable<Product> products);
	}
}

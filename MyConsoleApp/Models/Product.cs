﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Category { set; get; }
	}
}

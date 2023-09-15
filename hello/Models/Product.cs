using System;
using System.ComponentModel.DataAnnotations;
using hello.Data;
using Microsoft.EntityFrameworkCore;

namespace hello.Models
{
    public class Product
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
	}
}


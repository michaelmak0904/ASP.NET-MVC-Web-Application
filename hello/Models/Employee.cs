﻿using System;
using hello.Data;
using Microsoft.EntityFrameworkCore;

namespace hello.Models
{
    public class Employee
	{
		public int id { get; set; }
		public string name { get; set; }
        public string email { get; set; }
    }
}


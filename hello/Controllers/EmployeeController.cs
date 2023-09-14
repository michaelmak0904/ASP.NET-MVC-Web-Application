using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hello.Data;
using hello.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hello.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return View();
        }
    }
}


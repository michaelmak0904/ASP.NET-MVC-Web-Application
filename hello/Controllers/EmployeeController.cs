﻿using System;
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
            //Add dummy data into session
            HttpContext.Session.SetString("welcomeMsg", "Good Morning");
            String msg = HttpContext.Session.GetString("welcomeMsg") ?? "";
            ViewBag.Message = msg;
            return View(employees);
        }
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) {
                return NotFound();
            }
            return View(employee);
        }
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return View(Index);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid) {
                _context.Update(employee);
                _context.SaveChanges();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            if (employee == null) {
                return NotFound();
            }
            if (ModelState.IsValid) {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}


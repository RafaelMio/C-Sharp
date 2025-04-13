﻿using Expenses.Data;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ExpenseAppContext _context;

        public ExpensesController(ExpenseAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }
    }
}

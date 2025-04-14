using Expenses.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Data.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly ExpenseAppContext _context;

        public ExpensesService(ExpenseAppContext context) 
        {
            _context = context;
        }

        public async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }
    }
}

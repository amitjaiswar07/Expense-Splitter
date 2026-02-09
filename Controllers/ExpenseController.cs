using ExpenseSplitter.Data;
using ExpenseSplitter.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseSplitter.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            ViewBag.GroupId = id;
            return View(_context.Expenses.Where(e => e.GroupId == id).ToList());
        }

        public IActionResult Create(int groupId)
        {
            ViewBag.GroupId = groupId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            expense.ExpenseDate = DateTime.Now;
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = expense.GroupId });
        }

        public IActionResult Summary(int groupId)
        {
            var expenses = _context.Expenses.Where(e => e.GroupId == groupId).ToList();
            var members = expenses.Select(e => e.PaidBy).Distinct().ToList();

            decimal total = expenses.Sum(e => e.Amount);
            decimal share = members.Count > 0 ? total / members.Count : 0;

            ViewBag.Total = total;
            ViewBag.Share = share;
            ViewBag.Members = members;
            ViewBag.GroupId = groupId;

            return View();
        }
    }
}

using ExpenseSplitter.Data;
using ExpenseSplitter.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseSplitter.Controllers
{
    public class GroupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Groups.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Group group)
        {
            group.CreatedDate = DateTime.Now;
            _context.Groups.Add(group);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

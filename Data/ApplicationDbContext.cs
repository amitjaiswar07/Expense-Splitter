using ExpenseSplitter.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseSplitter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Member> Members { get; set; } = null!;
        public DbSet<Expense> Expenses { get; set; } = null!;
    }
}

namespace ExpenseSplitter.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? Title { get; set; }
        public decimal Amount { get; set; }
        public string? PaidBy { get; set; }
        public int GroupId { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}

namespace Finance_Tracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } // "income" or "expense"

        public Transaction()
        {
            
        }
    }
}

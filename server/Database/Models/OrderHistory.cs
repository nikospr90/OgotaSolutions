namespace server.Database.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

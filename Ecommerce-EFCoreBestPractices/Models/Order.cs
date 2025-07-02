namespace Ecommerce_EFCoreBestPractices.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }

        public User User { get; set; } = default!;
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}

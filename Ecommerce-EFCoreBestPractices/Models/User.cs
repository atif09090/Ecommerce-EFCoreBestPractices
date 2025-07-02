namespace Ecommerce_EFCoreBestPractices.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}

﻿namespace Ecommerce_EFCoreBestPractices.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; } = default!;
        public Product Product { get; set; } = default!;
    }
}

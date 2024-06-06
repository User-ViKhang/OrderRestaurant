﻿namespace RestaurentAPI.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}

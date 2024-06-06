using RestaurentAPI.Data.Entities;

namespace RestaurentAPI.Models
{
    public class CreateOrderRequest
    {
        public int OrderNo { get; set; }
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItemRequest> OrderItems { get; set; }
    }

    public class OrderItemRequest
    {
        public int ItemId { get; set;}
        public int Quality { get; set;}
    }
}

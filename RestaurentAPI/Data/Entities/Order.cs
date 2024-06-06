using System.Text.Json.Serialization;

namespace RestaurentAPI.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}

using RestaurentAPI.Data.Entities;

namespace RestaurentAPI.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
        public Customer Customer { get; set; }
    }
}

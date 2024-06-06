namespace RestaurentAPI.Models
{
    public class ResponeModel<T>
    {
        public string message { get; set; }
        public bool result { get; set; }
        public T data { get; set; }
    }
}

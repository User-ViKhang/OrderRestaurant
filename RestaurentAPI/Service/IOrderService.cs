using RestaurentAPI.Data;
using RestaurentAPI.Data.Entities;
using RestaurentAPI.Models;

namespace RestaurentAPI.Service
{
    public interface IOrderService
    {
        Task<ResponeModel<bool>> CreateOrderItem(CreateOrderRequest request);
    }

    public class OrderService : IOrderService
    {
        private readonly RestautantDbContext _context;

        public OrderService(RestautantDbContext context)
        {
            _context = context;
        }

        public async Task<ResponeModel<bool>> CreateOrderItem(CreateOrderRequest request)
        {
            var order = new Order
            {
                OrderNo = request.OrderNo,
                GTotal = request.GTotal,
                PMethod = request.PMethod,
                CustomerId = request.CustomerId,
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            var orderItemList = new List<OrderItem>();
            foreach (var orderItem in request.OrderItems)
            {
                orderItemList.Add(new OrderItem
                {
                    OrderId = order.Id,
                    ItemId = orderItem.ItemId,
                    Quality = orderItem.Quality
                });
            }
            await _context.OrderItems.AddRangeAsync(orderItemList);
            await _context.SaveChangesAsync();
            return new ResponeAPI<bool>(true);
        }
    }
}

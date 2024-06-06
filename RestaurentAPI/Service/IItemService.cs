using RestaurentAPI.Data;
using RestaurentAPI.Data.Entities;
using RestaurentAPI.Models;

namespace RestaurentAPI.Service
{
    public interface IItemService
    {
        ResponeModel<List<Item>> GetItems();
    }

    public class ItemService : IItemService
    {
        private readonly RestautantDbContext _context;

        public ItemService(RestautantDbContext context)
        {
            _context = context;
        }

        public ResponeModel<List<Item>> GetItems()
        {
            var result = _context.Items.ToList();
            return new ResponeAPI<List<Item>>(result);
        }
    }
}

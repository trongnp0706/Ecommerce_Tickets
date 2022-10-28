using Ecommerce_Tickets.Models;

namespace Ecommerce_Tickets.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}

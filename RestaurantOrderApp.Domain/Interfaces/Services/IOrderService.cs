using RestaurantOrderApp.Domain.Entities;

namespace RestaurantOrderApp.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Order Get(string input);
    }
}

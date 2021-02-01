using RestaurantOrderApp.Domain.Entities;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface ITimeOfDay
    {
        Dish GetDish(string number);
    }
}
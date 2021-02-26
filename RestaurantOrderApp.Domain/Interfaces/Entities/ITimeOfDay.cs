using RestaurantOrderApp.Domain.Entities;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface ITimeOfDay
    {
        Meal GetMeal(string number);
    }
}
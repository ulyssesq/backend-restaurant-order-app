using RestaurantOrderApp.Domain.Interfaces.Entities;

namespace RestaurantOrderApp.Domain.Interfaces.Factories
{
    public interface ITimeOfDayFactory
    {
        ITimeOfDay GetInstance(string timeOfDay);
    }
}
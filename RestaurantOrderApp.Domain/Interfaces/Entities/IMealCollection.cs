using RestaurantOrderApp.Domain.Entities;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface IMealCollection
    {
        bool Add(Meal meal);

        void Sort();
    }
}

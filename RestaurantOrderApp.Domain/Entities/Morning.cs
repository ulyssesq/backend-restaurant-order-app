using RestaurantOrderApp.Domain.Interfaces.Entities;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Morning : ITimeOfDay
    {
        public Dish GetDish(string number)
        {
            switch (number)
            {
                case "1": return new Eggs();
                case "2": return new Toast();
                case "3": return new Coffee();
            }

            return new DishError();
        }
    }
}

using RestaurantOrderApp.Domain.Entities.Dishes;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Morning : ITimeOfDay
    {
        public DishBase GetDish(string number)
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

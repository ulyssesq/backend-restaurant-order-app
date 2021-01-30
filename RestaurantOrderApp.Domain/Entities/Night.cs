using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Night : ITimeOfDay
    {
        public DishBase GetDish(string number)
        {
            switch (number)
            {
                case "1": return new Steak();
                case "2": return new Potato();
                case "3": return new Wine();
                case "4": return new Cake();
            }

            throw new ArgumentException("Invalid input");
        }
    }
}
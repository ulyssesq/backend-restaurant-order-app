using RestaurantOrderApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface ITimeOfDay
    {
        DishBase GetDish(string number);
    }
}

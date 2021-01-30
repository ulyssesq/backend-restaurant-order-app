using RestaurantOrderApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface IDishCollection
    {
        DishBase Add(DishBase dish);

        void Sort();
    }
}

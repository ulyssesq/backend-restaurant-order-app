using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Wine : Dish
    {
        public Wine() : base(DataType.Drink, "wine")
        {

        }
    }
}

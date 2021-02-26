using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Coffee : Meal
    {
        public Coffee() : base(DataType.Drink, "coffee", true)
        {
            
        }
    }
}

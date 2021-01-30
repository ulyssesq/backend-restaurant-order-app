using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Coffee : DishBase
    {
        public Coffee() : base(DataType.Drink, "coffee", true)
        {
            
        }
    }
}

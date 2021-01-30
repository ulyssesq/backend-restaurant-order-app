using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Potato : DishBase
    {
        public Potato() : base(DataType.Side, "potato", true)
        {

        }
    }
}

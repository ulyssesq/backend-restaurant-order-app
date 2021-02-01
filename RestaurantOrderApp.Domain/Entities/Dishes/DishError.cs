using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class DishError : Dish
    {
        public DishError() : base(Enum.DataType.Error, "error")
        {

        }
    }
}

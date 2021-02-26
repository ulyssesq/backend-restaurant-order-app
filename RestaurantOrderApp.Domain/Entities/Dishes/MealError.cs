using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class MealError : Meal
    {
        public MealError() : base(Enum.DataType.Error, "error")
        {

        }
    }
}

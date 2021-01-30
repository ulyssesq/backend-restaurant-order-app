using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities.Dishes
{
    public class DishError : DishBase
    {
        public DishError() : base(Enum.DataType.Error, "error")
        {

        }
    }
}

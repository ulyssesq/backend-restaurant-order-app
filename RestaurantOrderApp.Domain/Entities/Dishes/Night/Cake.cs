using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Cake : Dish
    {
        public Cake() : base(DataType.Dessert, "cake")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Dish
    {
        public int Number { get; set; }
        public int Quantity { get; set; }
        public int Order { get; set; }
    }
}

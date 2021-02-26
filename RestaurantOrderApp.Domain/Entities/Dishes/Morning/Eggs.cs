using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Eggs : Meal
    {
        public Eggs() : base(DataType.Entree, "eggs")
        {

        }
    }
}

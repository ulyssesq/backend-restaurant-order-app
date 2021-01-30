﻿using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Steak : DishBase
    {
        public Steak() : base(DataType.Entree, "steak")
        {

        }
    }
}

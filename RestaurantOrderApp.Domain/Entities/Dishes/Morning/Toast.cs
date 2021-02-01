﻿using System;
using System.Collections.Generic;
using System.Text;
using RestaurantOrderApp.Domain.Enum;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Toast : Dish
    {
        public Toast() : base(DataType.Side, "toast")
        {

        }
    }
}

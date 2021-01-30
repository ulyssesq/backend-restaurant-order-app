using RestaurantOrderApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class DishBase
    {
        public int Quantity { get; set; }
        public DataType DataType { get; set; }
        public string Name { get; set; }
        public bool CanRepeat { get; set; }

        public DishBase(DataType dataType, string name, bool canRepeat)
        {
            Quantity = 1;
            DataType = dataType;
            Name = name;
            CanRepeat = canRepeat;
        }

        public DishBase(DataType dataType, string name) : this(dataType, name, false)
        {
            
        }

        public bool Increment()
        {
            if (CanRepeat)
            {
                Quantity++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            if (Quantity == 1)
            {
                return Name;
            }
            else
            {
                return $"{Name}(x{Quantity})";
            }
        }
    }
}

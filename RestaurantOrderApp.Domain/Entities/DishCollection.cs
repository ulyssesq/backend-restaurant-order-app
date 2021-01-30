using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantOrderApp.Domain.Entities
{    
    public class DishCollection : IDishCollection
    {
        private List<DishBase> Dishes;

        public DishCollection()
        {
            Dishes = new List<DishBase>();
        }

        public DishBase Add(DishBase newDish)
        {
            if (Exists(newDish))
            {
                var dish = Get(newDish);
                dish.Increment();
            }
            else
            {
                Dishes.Add(newDish);
            }

            return newDish;
        }

        private bool Exists(DishBase dish)
        {
            return Dishes.Any(d => d.DataType == dish.DataType);
        }

        private DishBase Get(DishBase dish)
        {
            return Dishes.First(d => d.DataType == dish.DataType);
        }

        public void Sort()
        {
            Dishes = Dishes.OrderBy(d => d.DataType).ToList();
        }

        public override string ToString()
        {
            return String.Join(", ", Dishes.Select(c => c.ToString()).ToArray());
        }
    }
}

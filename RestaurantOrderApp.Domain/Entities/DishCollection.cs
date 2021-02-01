using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantOrderApp.Domain.Entities
{
    public class DishCollection : IDishCollection
    {
        private List<Dish> Dishes;

        public DishCollection()
        {
            Dishes = new List<Dish>();
        }

        public bool Add(Dish newDish)
        {
            if (Exists(newDish))
            {
                return IncrementIfValid(newDish);
            }
            else
            {
                Dishes.Add(newDish);
                return true;
            }
        }

        private bool IncrementIfValid(Dish newDish)
        {
            var dish = Get(newDish);
            if (dish.Increment())
            {
                return true;
            }
            else
            {
                Dishes.Add(new DishError());
                return false;
            }
        }

        private bool Exists(Dish dish)
        {
            return Dishes.Any(d => d.DataType == dish.DataType);
        }

        private Dish Get(Dish dish)
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
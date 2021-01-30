using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RestaurantOrderApp.Domain.Entities.Dishes;

namespace RestaurantOrderApp.Domain.Entities
{    
    public class DishCollection : IDishCollection
    {
        private List<DishBase> Dishes;

        public DishCollection()
        {
            Dishes = new List<DishBase>();
        }

        public bool Add(DishBase newDish)
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

        private bool IncrementIfValid(DishBase newDish)
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

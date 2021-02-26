using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantOrderApp.Domain.Entities
{
    public class MealCollection : IMealCollection
    {
        private List<Meal> Meals;

        public MealCollection()
        {
            Meals = new List<Meal>();
        }

        public bool Add(Meal newMeal)
        {
            if (Exists(newMeal))
            {
                return IncrementIfValid(newMeal);
            }
            else
            {
                Meals.Add(newMeal);
                return true;
            }
        }

        private bool IncrementIfValid(Meal newMeal)
        {
            var meal = Get(newMeal);
            if (meal.Increment())
            {
                return true;
            }
            else
            {
                Meals.Add(new MealError());
                return false;
            }
        }

        private bool Exists(Meal meal)
        {
            return Meals.Any(d => d.DataType == meal.DataType);
        }

        private Meal Get(Meal meal)
        {
            return Meals.First(d => d.DataType == meal.DataType);
        }

        public void Sort()
        {
            Meals = Meals.OrderBy(d => d.DataType).ToList();
        }

        public override string ToString()
        {
            return String.Join(", ", Meals.Select(c => c.ToString()).ToArray());
        }
    }
}
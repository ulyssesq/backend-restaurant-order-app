using RestaurantOrderApp.Domain.Enum;
using RestaurantOrderApp.Domain.Factories;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RestaurantOrderApp.Domain.Entities
{
    public class OrderManager
    {
        public ITimeOfDay TimeOfDay { get; set; }
        public IDishCollection Dishes { get; set; }

        public OrderManager()
        {
            Dishes = new DishCollection();
        }

        public string GetOutput(string input)
        {
            // Process order
            var items = input.Split(',').ToList();

            TimeOfDay = TimeOfDayFactory.GetInstance(items.First());

            // First is the time of day, so take it.
            var orderNumbers = items.Take(1);

            foreach (var number in orderNumbers)
            {
                var dish = TimeOfDay.GetDish(number);

                Dishes.Add(dish);
            }

            Dishes.Sort();

            return Dishes.ToString();
        }
    }
}
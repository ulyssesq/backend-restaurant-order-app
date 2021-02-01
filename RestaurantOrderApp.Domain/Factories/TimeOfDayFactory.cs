using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using System;

namespace RestaurantOrderApp.Domain
{
    public class TimeOfDayFactory
    {
        public static ITimeOfDay GetInstance(string timeOfDay)
        {
            switch (timeOfDay)
            {
                case "morning": return new Morning();
                case "night": return new Night();
            }

            throw new ArgumentException("Invalid Time of Day");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Factories
{
    public class DishFactory
    {
        public static IDish GetInstance(string input)
        {
            switch (input.First())
            {
                case 'N': return new NorthCommand(input);
                case 'S': return new SouthCommand(input);
                case 'L': return new EastCommand(input);
                case 'O': return new WestCommand(input);
                case 'X': return new CancelCommand(input);
            }

            throw new ArgumentException("Invalid input");
        }
    }
}

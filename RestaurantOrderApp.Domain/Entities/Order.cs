using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Entities
{
    public class Order
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public Order(string input, string output)
        {
            Input = input;
            Output = output;
        }
    }
}

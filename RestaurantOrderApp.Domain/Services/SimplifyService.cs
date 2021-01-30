using RestaurantOrderApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Services
{
    public class SimplifyService : ISimplifyService
    {
        public string Simplify(string input)
        {
            return input.Replace(" ", "").ToLower();
        }
    }
}

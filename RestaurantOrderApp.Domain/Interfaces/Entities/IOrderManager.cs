using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Interfaces.Entities
{
    public interface IOrderManager
    {
        string GetOutput(string input);
    }
}

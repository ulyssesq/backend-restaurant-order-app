﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderApp.Domain.Interfaces.Services
{
    public interface IValidationService
    {
        bool IsValid(string input);
    }
}

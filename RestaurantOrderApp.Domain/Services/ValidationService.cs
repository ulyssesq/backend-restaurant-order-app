using RestaurantOrderApp.Domain.Interfaces.Services;
using System;
using System.Text.RegularExpressions;

namespace RestaurantOrderApp.Domain.Services
{
    public class ValidationService : IValidationService
    {
        private const string FullPattern = @"^(morning|night)(,\s?\d)+$";
        public bool IsValid(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, FullPattern, RegexOptions.IgnoreCase);
            }
        }
    }   
}
using RestaurantOrderApp.Domain.Interfaces.Services;

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
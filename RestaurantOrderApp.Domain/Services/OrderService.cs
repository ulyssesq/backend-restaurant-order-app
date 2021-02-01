using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Factories;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using RestaurantOrderApp.Domain.Interfaces.Services;
using System.Linq;

namespace RestaurantOrderApp.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly ISimplifyService _simplifyService;
        private readonly IValidationService _validationService;

        public ITimeOfDay TimeOfDay { get; set; }
        public IDishCollection Dishes { get; set; }

        public OrderService(IValidationService validationService, ISimplifyService simplifyService)
        {
            _simplifyService = simplifyService;
            _validationService = validationService;
            Dishes = new DishCollection();
        }

        public Order Get(string input)
        {
            return new Order()
            {
                Input = input,
                Output = GetOutput(input)
            };
        }

        private string GetOutput(string input)
        {
            if (!_validationService.IsValid(input))
            {
                var dishError = new DishError();
                return dishError.ToString();
            }
            else
            {
                // Simplify order - remove spaces and turn in lowercase
                var inputSimplified = _simplifyService.Simplify(input);

                var items = inputSimplified.Split(',').ToList();

                TimeOfDay = TimeOfDayFactory.GetInstance(items.First());

                // First is the time of day, so take it.
                var orderNumbers = items.Skip(1);

                foreach (var number in orderNumbers)
                {
                    var dish = TimeOfDay.GetDish(number);

                    if (!Dishes.Add(dish))
                    {
                        break;
                    }
                }

                Dishes.Sort();

                return Dishes.ToString();
            }
        }
    }
}

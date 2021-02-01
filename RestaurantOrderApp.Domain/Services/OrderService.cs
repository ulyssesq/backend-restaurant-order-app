using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using RestaurantOrderApp.Domain.Interfaces.Factories;
using RestaurantOrderApp.Domain.Interfaces.Services;
using System.Linq;

namespace RestaurantOrderApp.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly ISimplifyService _simplifyService;
        private readonly IValidationService _validationService;
        private readonly ITimeOfDayFactory _timeOfDayFactory;

        private ITimeOfDay TimeOfDay;
        private IDishCollection Dishes;

        public OrderService(IValidationService validationService, ISimplifyService simplifyService, ITimeOfDayFactory timeOfDayFactory)
        {
            _simplifyService = simplifyService;
            _validationService = validationService;
            _timeOfDayFactory = timeOfDayFactory;
            Dishes = new DishCollection();
        }

        public Order Get(string input)
        {
            string output;

            if (!_validationService.IsValid(input))
            {
                var dishError = new DishError();
                output = dishError.ToString();
            }
            else
            {
                // Simplify order - remove spaces and turn in lowercase
                var inputSimplified = _simplifyService.Simplify(input);

                var items = inputSimplified.Split(',').ToList();

                TimeOfDay = _timeOfDayFactory.GetInstance(items.First());

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

                output = Dishes.ToString();
            }

            return new Order(input, output);
        }
    }
}
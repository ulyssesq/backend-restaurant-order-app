using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Interfaces.Entities;
using RestaurantOrderApp.Domain.Interfaces.Services;


namespace RestaurantOrderApp.Domain.Services
{
    public class OrderService : IOrderService
    {
        private IValidationService ValidationService;
        private ISimplifyService SimplifyService;
        private IOrderManager OrderManager;

        public OrderService(IValidationService validationService, ISimplifyService simplifyService, IOrderManager orderManager)
        {
            ValidationService = validationService;
            SimplifyService = simplifyService;
            OrderManager = orderManager;
        }

        public Order Get(string input)
        {
            var order = new Order()
            {
                Input = input
            };

            if (!ValidationService.IsValid(input))
            {
                var dishError = new DishError();
                order.Output = dishError.ToString();
            }
            else
            {
                // Simplify order - remove spaces and turn in lowercase
                var inputSimplified = SimplifyService.Simplify(input);

                // Process order
                order.Output = OrderManager.GetOutput(inputSimplified);
            }

            return order;
        }
    }
}

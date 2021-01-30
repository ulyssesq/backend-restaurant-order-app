using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantOrderApp.Domain.Services
{
    public class OrderService : IOrderService
    {
        private IValidationService ValidationService;
        private ISimplifyService SimplifyService;

        public OrderService(IValidationService validationService, ISimplifyService simplifyService)
        {
            ValidationService = validationService;
            SimplifyService = simplifyService;
        }

        public Order Get(string input)
        {
            var order = new Order()
            {
                Input = input
            };

            if (!ValidationService.IsValid(input))
            {
                order.Output = "error";
                return order;
            }

            // Simplify order - remove spaces and turn in lowercase
            var inputSimplified = SimplifyService.Simplify(input);

            // Process order
            var OrderManager = new OrderManager();
            order.Output = OrderManager.GetOutput(inputSimplified);

            return order;
        }
    }
}

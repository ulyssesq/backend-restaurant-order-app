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

        public OrderService(IValidationService validationService)
        {
            ValidationService = validationService;
        }

        private string Simplify(string input)
        {
            return input.Replace(" ", "").ToLower();
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
            var inputSimplified = Simplify(input);

            // Process order
            var items = inputSimplified.Split(',').ToList();

            var timeOfDay = items.First();

            var orderNumbers = items.Take(1);
            var dishes = new List<Dish>();

            // percorre numeros
            foreach (var number in orderNumbers)
            {
                var dish = dishes.GetByNumber(number);

                // se não existe cria, se existe adiciona um no contador
                if (dish != null)
                {
                    dish.Quantity++;
                }
                else
                {
                    dish = new Dish(number);
                }

                // validar com regras de negocio se ok contiua senão retorna error
                // criar enumerador
                if (timeOfDay == "night")
                {
                    // verifica regra da batata
                }

                if (timeOfDay == "morning")
                {
                    // verifica regra do coffee
                }
                
                
            }

            // coloca em ordem // dish deve ter um metodo .ToString() nome e quantidade se for maior que um
            var orderdDishes = dishes.OrderBy(c => c.Order).ToList();

            order.Output = String.Join(',', orderdDishes.Select(c => c.ToString()).ToArray());

            return order;
        }
    }
}

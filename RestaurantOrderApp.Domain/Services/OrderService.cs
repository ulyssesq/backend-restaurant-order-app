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

        public Order Get(string input)
        {
            if (!ValidationService.IsValid(input))
            {
                return new Order.Error()
                {
                    Input = input,
                    Output = "error"
                };
            }

            // Simplify order - remove spaces and turn in lowercase
            var OrderManager = ishes

            // Process order
            // percorre numeros
            // se não existe cria, se existe adiciona um no contador
            // validar com regras de negocio se ok contiua senão retorna error
            // coloca em ordem // dish deve ter um metodo .ToString() nome e quantidade se for maior que um

            

            var items = input.Split(',').ToList();
            string timeOfDay = items.First();

            
            var dishes = items.Take(1).Select(i => new Dish())





            //Pegar tudo e colocar em uma estrutura / lista

            // Vai passando item a item para aplicar as regras

            // retorna uma estrutura com os pratos e quantidades de cada um

            // algo como prato e quantidade
            // timeofday

            // printa o resultado
            // retornar o output na order



            throw new NotImplementedException();
        }
    }
}

using RestaurantOrderApp.Domain.Entities;
using RestaurantOrderApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
                return new Order()
                {
                    Input = input,
                    Output = "error"
                };
            }

            //Limpar espaços, botar tudo em minusculo

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

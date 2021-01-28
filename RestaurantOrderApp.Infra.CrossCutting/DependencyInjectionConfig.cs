using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderApp.Domain.Interfaces.Services;
using RestaurantOrderApp.Domain.Services;
using System;

namespace RestaurantOrderApp.Infra.CrossCutting
{
    public class DependencyInjectionConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IValidationService, ValidationService>()
                    .AddTransient<IOrderService, OrderService>();
        }
    }
}

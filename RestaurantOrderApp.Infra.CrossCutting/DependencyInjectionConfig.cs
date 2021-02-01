using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderApp.Domain;
using RestaurantOrderApp.Domain.Interfaces.Factories;
using RestaurantOrderApp.Domain.Interfaces.Services;
using RestaurantOrderApp.Domain.Services;

namespace RestaurantOrderApp.Infra.CrossCutting
{
    public class DependencyInjectionConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IValidationService, ValidationService>()
                    .AddTransient<IOrderService, OrderService>()
                    .AddTransient<ISimplifyService, SimplifyService>()
                    .AddTransient<IOrderService, OrderService>()
                    .AddTransient<ITimeOfDayFactory, TimeOfDayFactory>();
        }
    }
}
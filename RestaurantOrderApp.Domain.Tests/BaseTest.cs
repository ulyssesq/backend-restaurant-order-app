using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderApp.Infra.CrossCutting;

namespace RestaurantOrderApp.Domain.Tests
{
    public class BaseTest
    {
        public ServiceProvider ServiceProvider { get; set; }

        public BaseTest()
        {
            var services = new ServiceCollection();
            DependencyInjectionConfig.Configure(services);
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
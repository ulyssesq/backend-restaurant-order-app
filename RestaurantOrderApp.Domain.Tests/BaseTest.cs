using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderApp.Infra.CrossCutting;
using System;
using System.Collections.Generic;
using System.Text;

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

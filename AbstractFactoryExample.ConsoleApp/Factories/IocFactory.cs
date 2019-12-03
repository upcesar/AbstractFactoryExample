using AbstractFactoryExample.ConsoleApp.Classes.Animals;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public static class IocFactory
    {
        #region Variables

        private static IServiceCollection instance;

        #endregion

        #region Public Methods
        public static IServiceCollection GetInstance()
            => instance ??= new ServiceCollection()
                                .SetupFactories();
        private static IServiceCollection SetupFactories(this IServiceCollection services)
            => services.AddSingleton<AnimalFactory>()
                       .AddSingleton<FoodFactory>();

        #endregion
    }
}

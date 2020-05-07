using Microsoft.Extensions.DependencyInjection;

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
            => services.AddSingleton<IAnimalFactory, AnimalFactory>()
                       .AddSingleton<IFoodFactory, FoodFactory>();

        #endregion
    }
}

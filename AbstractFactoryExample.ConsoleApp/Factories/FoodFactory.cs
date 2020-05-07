using AbstractFactoryExample.ConsoleApp.Foods;
using System.Collections.Generic;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public interface IFoodFactory : IFactory<string, IFood> { }

    public class FoodFactory : Factory<string, IFood>, IFoodFactory
    {
        protected override Dictionary<string, IFood> CreateInstancesDictionary() 
            => new Dictionary<string, IFood> {
                { "plants", new Plants() },
                { "meat",   new Meat() }
            };
    }
}

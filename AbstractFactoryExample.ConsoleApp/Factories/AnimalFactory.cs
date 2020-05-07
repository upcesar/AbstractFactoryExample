using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Classes.Animals;
using System.Collections.Generic;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public interface IAnimalFactory : IFactory<AnimalEnum, IAnimals> { }
    
    public class AnimalFactory : Factory<AnimalEnum, IAnimals>, IAnimalFactory
    {
        protected override Dictionary<AnimalEnum, IAnimals> CreateInstancesDictionary()
            => new Dictionary<AnimalEnum, IAnimals>
            {
                { AnimalEnum.WOLF,  new Wolf()  },
                { AnimalEnum.SHEEP, new Sheep() }
            };
    }
}

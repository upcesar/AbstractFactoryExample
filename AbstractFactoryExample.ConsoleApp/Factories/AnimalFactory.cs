using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public class AnimalFactory : Factory<AnimalEnum, IAnimals>
    {
        protected override Dictionary<AnimalEnum, IAnimals> CreateInstancesDictionary()
            => new Dictionary<AnimalEnum, IAnimals>
            {
                { AnimalEnum.WOLF,  new Wolf()  },
                { AnimalEnum.SHEEP, new Sheep() }
            };
    }
}

using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public class FoodFactory : Factory<string, IFood>
    {
        protected override Dictionary<string, IFood> CreateInstancesDictionary() 
            => new Dictionary<string, IFood> {
                { "plants", new Plants() },
                { "meat",   new Meat() }
            };
    }
}

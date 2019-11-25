using AbstractFactoryExample.ConsoleApp.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public interface IFood
    {
        string Name { get; }
        bool CanBeEatenBy(IAnimals animal);
    }
}

using AbstractFactoryExample.ConsoleApp.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public abstract class Food : IFood
    {
        public string Name => this.GetType().Name;
        public abstract bool CanBeEatenBy(IAnimals animal);
        public override string ToString() => $"Food: {this.Name}";
    }
}

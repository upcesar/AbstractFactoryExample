using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Classes.Animals;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public class Meat : IFood
    {
        public string Name => this.GetType().Name;
        public bool CanBeEatenBy(IAnimals animal) => animal is Wolf;
        public override string ToString() => $"Food: {this.Name}";
    }
}

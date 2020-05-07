using AbstractFactoryExample.ConsoleApp.Animals;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public class Plants : IFood
    {
        public string Name => this.GetType().Name;
        public bool CanBeEatenBy(IAnimals animal) => animal is Sheep;
        public override string ToString() => $"Food: {Name}";
    }
}

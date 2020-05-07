using AbstractFactoryExample.ConsoleApp.Animals;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public class Plants : Food, IFood
    {
        public override bool CanBeEatenBy(IAnimals animal) => animal is Sheep;
    }
}

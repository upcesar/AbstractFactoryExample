using AbstractFactoryExample.ConsoleApp.Animals;

namespace AbstractFactoryExample.ConsoleApp.Foods
{
    public class Meat : Food, IFood
    {
        public override bool CanBeEatenBy(IAnimals animal) => animal is Wolf;        
    }
}

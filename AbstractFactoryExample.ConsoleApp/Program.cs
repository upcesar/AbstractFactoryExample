using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Factories;
using AbstractFactoryExample.ConsoleApp.Foods;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AbstractFactoryExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = IocFactory.GetInstance()
                                     .BuildServiceProvider();

            var animalFactory = provider.GetService<IAnimalFactory>();
            var foodFactory = provider.GetService<IFoodFactory>();
            
            Console.WriteLine("Showing animal behaviors!");
            Console.WriteLine(new string('*', 15));

            var wolf = animalFactory.CreateInstance<Wolf>();
            var sheep = animalFactory.CreateInstance<Sheep>();

            var plants = foodFactory.CreateInstance<Plants>();
            var meat = foodFactory.CreateInstance<Meat>();


            wolf.InteractWith(sheep);
            sheep.InteractWith(wolf);

            wolf.Sleep(8);
            sheep.Sleep(3);

            wolf.Eat(meat);
            sheep.Eat(plants);
            
            wolf.Eat(plants);
            sheep.Eat(meat);

            Console.WriteLine(wolf.ShowHistory());
            Console.WriteLine(new string('*', 15));
            Console.WriteLine(sheep.ShowHistory());
        
        }
        
    }
}

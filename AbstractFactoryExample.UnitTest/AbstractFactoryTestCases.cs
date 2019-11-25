using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Classes.Animals;
using AbstractFactoryExample.ConsoleApp.Factories;
using System;
using Xunit;

namespace AbstractFactoryExample.UnitTest
{
    public class AbstractFactoryTestCases
    {
        private readonly AnimalFactory animalFactory;
        private readonly FoodFactory foodFactory;
        public AbstractFactoryTestCases()
        {
            animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
        }

        [Fact]
        public void SheepInstanceTest()
            => Assert.IsType<Sheep>(animalFactory.CreateInstance(AnimalEnum.SHEEP));
        [Fact]
        public void NotWolfInstanceTest()
            => Assert.IsNotType<Wolf>(animalFactory.CreateInstance(AnimalEnum.SHEEP));

        [Fact]
        public void GenericsInstanceTest()
            => Assert.IsType<Wolf>(animalFactory.CreateInstance<Wolf>());
        
        [Fact]
        public void IsNullInstanceTest()
            => Assert.Null(foodFactory.CreateInstance("snacks"));
    }
}

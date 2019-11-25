using AbstractFactoryExample.ConsoleApp.Animals;
using AbstractFactoryExample.ConsoleApp.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Classes.Animals
{
    public class Wolf : Animal
    {
        public override void InteractWith(IAnimals another)
        {
            if (another is Wolf)
            {
                Trace($"I am interacting with another {another.Name} as part of a pack");
                return;
            }
            
            Trace($"I am hunting a {another.Name}");            
        }

        public override void Sleep(int hour)
            => Trace(hour >= 4 ? $"I feel renewed" : "I didn't sleep very well");
    }
}

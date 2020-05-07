using AbstractFactoryExample.ConsoleApp.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public interface IAnimals
    {
        string Name { get; }
        void Eat(IFood food);
        void Sleep(int hour);
        void InteractWith(IAnimals other);
        string ShowHistory();
    }
}

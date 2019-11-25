namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public class Sheep : Animal
    {
        public override void InteractWith(IAnimals another)
            => Trace($"I like to interact with everyone, no matter whether it is a {another.GetType().Name}");

        public override void Sleep(int hour)
            => Trace($"I slept but I am awakinng up every {hour} hours for 3 times");
    }
}

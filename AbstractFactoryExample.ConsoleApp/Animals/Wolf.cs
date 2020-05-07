namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public class Wolf : Animal
    {
        public override void InteractWith(IAnimals another)
        {
            if (another is Wolf)
            {
                traceable.Trace($"I am interacting with another {another.Name} as part of a pack");
                return;
            }

            traceable.Trace($"I am hunting a {another.Name}");
        }

        public override void Sleep(int hour)
            => traceable.Trace(hour >= 4 ? $"I feel renewed" : "I didn't sleep very well");
    }
}

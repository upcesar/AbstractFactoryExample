using AbstractFactoryExample.ConsoleApp.Foods;

namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public abstract class Animal : IAnimals
    {
        protected readonly ITraceable traceable;

        public string Name => this.GetType().Name;

        public Animal() => traceable = new Traceable(Name);

        public void Eat(IFood food)
        {
            var eatPhrase = food.CanBeEatenBy(this) ? "eats" : "doesn't eat";
            traceable.Trace($"{this.Name} {eatPhrase} {food.Name}");
        }

        public abstract void InteractWith(IAnimals other);

        public abstract void Sleep(int hour);

        public override string ToString() => $"Animal: {this.Name}";

        public string ShowHistory() => traceable.ToString();
    }
}

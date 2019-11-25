namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public interface IFactory<TKey, TObject> where TObject : class
    {
        TObject CreateInstance(TKey key);
        T CreateInstance<T>() where T : class, TObject, new();
    }
}

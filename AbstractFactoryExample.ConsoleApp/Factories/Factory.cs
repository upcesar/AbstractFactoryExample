using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryExample.ConsoleApp.Factories
{
    public abstract class Factory<TKey, TObject> : IFactory<TKey, TObject> where TObject : class
    {
        protected Dictionary<TKey, TObject> Instances { get; private set; }

        public Factory()
            => Instances = CreateInstancesDictionary();

        public TObject CreateInstance(TKey key)
            => Instances.FirstOrDefault(instance => instance.Key.Equals(key)).Value;

        public TObject CreateInstance<T>() where T : class, TObject, new()
            => Instances.FirstOrDefault(instance => typeof(T).Equals(instance.Value.GetType())).Value as T;

        protected abstract Dictionary<TKey, TObject> CreateInstancesDictionary();

    }
}

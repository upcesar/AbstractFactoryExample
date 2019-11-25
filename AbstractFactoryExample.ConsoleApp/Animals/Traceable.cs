using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public abstract class Traceable
    {
        private readonly List<string> _log = new List<string>();

        public Traceable() => Trace($"{GetType().Name} Initialized");

        protected void Trace(string message) => _log.Add($"{message} at {DateTime.Now}");

        public string ShowHistory() => string.Join(Environment.NewLine, _log);
    }
}

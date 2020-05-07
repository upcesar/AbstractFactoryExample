using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.ConsoleApp.Animals
{
    public class Traceable : ITraceable
    {
        private readonly List<string> _log = new List<string>();

        public Traceable(string className) => Trace($"{className} Initialized");

        public void Trace(string message) => _log.Add($"{message} at {DateTime.Now}");

        public override string ToString() => string.Join(Environment.NewLine, _log);
    }
}

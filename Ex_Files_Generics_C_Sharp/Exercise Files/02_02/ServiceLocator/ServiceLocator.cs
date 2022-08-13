using System;
using System.Collections;
using Example.Services;

namespace Example
{
    public class ServiceLocator
    {
        private Hashtable _registry = new Hashtable();

        public void AddService(string name, Type service)
        {
            _registry[name] = service;
        }

        public object CreateService(string key) {
            var type = (Type)_registry[key];
            return Activator.CreateInstance(type);
        }
    }
}

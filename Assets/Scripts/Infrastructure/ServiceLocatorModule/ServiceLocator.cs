using System;
using System.Collections.Generic;

namespace Infrastructure.ServiceLocatorModule
{
    public class ServiceLocator
    {
        public static ServiceLocator Instance { get; } = new ServiceLocator();
        private readonly Dictionary<Type, IService> _services = new Dictionary<Type, IService>();

        public void RegisterService<TService>(TService service) where TService : class, IService
        {
            _services.TryAdd(typeof(TService), service);
        }

        public void UnregisterService<TService>() where TService : class, IService
        {
            _services.Remove(typeof(TService));
        }

        public TService GetServise<TService>() where TService : class, IService
        {
            if (_services.TryGetValue(typeof(TService), out var service))
            {
                return (TService)service;
            }
            return null;
        }
    }
}
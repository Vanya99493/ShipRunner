using System.Collections.Generic;
using Infrastructure.EventBusModule.EventBusArguments;
using Infrastructure.ServiceLocatorModule;

namespace Infrastructure.EventBusModule
{
    public class EventBus : IService
    {
        private readonly Dictionary<string, List<EventBusHandler<IEventBusArgs>>> _subscribers;

        public EventBus()
        {
            _subscribers = new Dictionary<string, List<EventBusHandler<IEventBusArgs>>>();
        }
        
        public void Subscribe(string eventName, EventBusHandler<IEventBusArgs> action)
        {
            if (!_subscribers.ContainsKey(eventName))
            {
                _subscribers.Add(eventName, new List<EventBusHandler<IEventBusArgs>>());
            }
            _subscribers[eventName].Add(action);
        }

        public void Unsubscribe<T>(string eventName, EventBusHandler<T> action) where T : IEventBusArgs
        {
            if (_subscribers.TryGetValue(eventName, out List<EventBusHandler<IEventBusArgs>> subscriber))
            {
                //subscriber.Remove(action);
            }
        }

        public void Raise(string eventName, IEventBusArgs args)
        {
            if (!_subscribers.TryGetValue(eventName, out List<EventBusHandler<IEventBusArgs>> subscribers))
            {
                foreach (EventBusHandler<IEventBusArgs> subscriber in subscribers)
                {
                    subscriber(args);
                }
            }
        }
    }
}
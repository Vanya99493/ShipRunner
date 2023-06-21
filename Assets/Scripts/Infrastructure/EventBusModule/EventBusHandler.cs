using Infrastructure.EventBusModule.EventBusArguments;

namespace Infrastructure.EventBusModule
{
    public delegate void EventBusHandler<T>(T args) where T : IEventBusArgs;
}
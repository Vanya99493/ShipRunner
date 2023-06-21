namespace Infrastructure.EventBusModule.EventBusArguments
{
    public class EventBusArgsWithInt : IEventBusArgs
    {
        public int Number { get; private set; }

        public EventBusArgsWithInt(int number)
        {
            Number = number;
        }
    }
}
using Infrastructure.EventBusModule;
using Infrastructure.EventBusModule.EventBusArguments;
using Infrastructure.ServiceLocatorModule;
using Infrastructure.StateMachine;

namespace Infrastructure
{
    public class Game
    {
       private readonly GameStateMachine _stateMachine;
       private readonly ServiceLocator _serviceLocator;
       private readonly EventBus _eventBus;

       public Game()
       {
           _stateMachine = new GameStateMachine();
           _serviceLocator = new ServiceLocatorModule.ServiceLocator();
           _eventBus = new EventBus();
           
           _serviceLocator.RegisterService(_eventBus);
           
           //_eventBus.Subscribe("s", So);
           //_eventBus.Subscribe("sint", SoInt);
           
           //_eventBus.Raise("s", new EventBusArgs());
           //_eventBus.Raise("sint", new EventBusArgsWithInt(5));
       }

       /*private void So(EventBusArgs e)
       {
           
       }

       private void SoInt(EventBusArgsWithInt e)
       {
           
       }*/
    }
}
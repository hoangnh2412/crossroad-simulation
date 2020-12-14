using System;
using System.Threading.Tasks;
using CrossroadSimulation.Constants;
using CrossroadSimulation.Events;
using CrossroadSimulation.Objects.Abstractions;

namespace CrossroadSimulation.Objects
{
    public class Car : ICar
    {
        public string Name => throw new NotImplementedException();

        public int Speed => throw new NotImplementedException();

        public int Distance => throw new NotImplementedException();

        public bool IsRunning => throw new NotImplementedException();

        public event EventHandler<CarRunningEvent> Running;
        public event EventHandler<CarStartedEvent> Started;
        public event EventHandler<CarStopedEvent> Stoped;

        public Car(string name, int speed, Direction direction)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task RunAsync()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
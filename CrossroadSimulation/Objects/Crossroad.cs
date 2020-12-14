using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrossroadSimulation.Constants;
using CrossroadSimulation.Objects.Abstractions;

namespace CrossroadSimulation.Objects
{
    public class Crossroad : ICrossroad
    {
        public Dictionary<Direction, IRoad> Roads { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<Direction, ITrafficLight> TrafficLights { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<Direction, ConcurrentDictionary<string, ICar>> Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<Direction, Queue<ICar>> WaitCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Crossroad()
        {
        }

        public void AddRoad(Direction direction, int startPosition, int endPosition, int startCrossroadPosition, int endCrossroadPosition)
        {
            throw new NotImplementedException();
        }

        public void AddTrafficLight(Direction direction, string name, TrafficLightColor color, Dictionary<TrafficLightColor, int> colors)
        {
            throw new NotImplementedException();
        }

        public void AddCar(Direction direction, string name, int speed)
        {
            throw new NotImplementedException();
        }
    }
}
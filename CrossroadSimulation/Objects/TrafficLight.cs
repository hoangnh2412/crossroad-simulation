using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrossroadSimulation.Constants;
using CrossroadSimulation.Events;
using CrossroadSimulation.Objects.Abstractions;

namespace CrossroadSimulation.Objects
{
    public class TrafficLight : ITrafficLight
    {
        public string Name => throw new NotImplementedException();

        public TrafficLightColor Color => throw new NotImplementedException();

        public int Countdown => throw new NotImplementedException();

        public event EventHandler<TrafficLightRunningEvent> Running;
        public event EventHandler<TrafficLightChangeColorEvent> ChangedColor;

        /// <summary>
        /// Colors and time with each colors
        /// </summary>
        private Dictionary<TrafficLightColor, int> Colors;

        public TrafficLight(string name, Dictionary<TrafficLightColor, int> colors, TrafficLightColor color, int countdown)
        {
        }

        public void ChangeColor()
        {
            throw new NotImplementedException();
        }

        public Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
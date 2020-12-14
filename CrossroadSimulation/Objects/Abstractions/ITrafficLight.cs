using System;
using System.Threading.Tasks;
using CrossroadSimulation.Constants;
using CrossroadSimulation.Events;

namespace CrossroadSimulation.Objects.Abstractions
{
    public interface ITrafficLight
    {
        /// <summary>
        /// The identity name of Trafficlight
        /// </summary>
        /// <value></value>
        string Name { get; }

        /// <summary>
        /// Current color of Trafficlight
        /// 1 = Red, 2 = Green
        /// </summary>
        TrafficLightColor Color { get; }

        /// <summary>
        /// Current countdown of Trafficlight
        /// </summary>
        int Countdown { get; }

        /// <summary>
        /// The event executed when trafficlight is running
        /// </summary>
        event EventHandler<TrafficLightRunningEvent> Running;

        /// <summary>
        /// The event executed after color is changed
        /// </summary>
        event EventHandler<TrafficLightChangeColorEvent> ChangedColor;

        /// <summary>
        /// Execute when start simulation
        /// Use while(true) for simulate trafficlight is running
        /// If Countdown = 0 then ChangeColor()
        /// If Countdown > 0 then reduction Countdown
        /// </summary>
        /// <returns></returns>
        Task RunAsync();

        /// <summary>
        /// Change color of Trafficlight
        /// If Color is Red then change to Green.
        /// If Color is Green then change to Red.
        /// </summary>
        void ChangeColor();
    }
}
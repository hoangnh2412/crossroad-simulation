using System.Collections.Concurrent;
using System.Collections.Generic;
using CrossroadSimulation.Constants;

namespace CrossroadSimulation.Objects.Abstractions
{
    /// <summary>
    /// The interface simulate Crossroad
    /// TODO: In the future, for visualize Road, Car, Trafficlight need to be use X, Y coordinates for CarRunningEvent and TraffilightRunningEvent
    /// </summary>
    public interface ICrossroad
    {
        /// <summary>
        /// Roads of the crossroad
        /// Use Directory for select road by direciton
        /// </summary>
        /// <value></value>
        Dictionary<Direction, IRoad> Roads { get; set; }

        /// <summary>
        /// Trafficlights of the crossroad
        /// Use Dictionary for select trafficlight by direction
        /// </summary>
        /// <value></value>
        Dictionary<Direction, ITrafficLight> TrafficLights { get; set; }

        /// <summary>
        /// Cars has run and stop on the crossroad
        /// Use Dictionary for select Cars by direction
        /// Use ConcurrentDictionary for cars because have multithread
        /// - Add car when simulation
        /// - Remove car when run to end of road. Destroy car instance from GC avoid the case leak memory
        /// </summary>
        /// <value></value>
        Dictionary<Direction, ConcurrentDictionary<string, ICar>> Cars { get; set; }

        /// <summary>
        /// Cars stop for wait trafficlight change to Green
        /// Use Dictionary for select WaitCars by direction
        /// Use Queue for cars leave the crossroad in the same order which they arrived
        /// </summary>
        /// <value></value>
        Dictionary<Direction, Queue<ICar>> WaitCars { get; set; }

        /// <summary>
        /// Create new Road instance and add to Roads for simulation
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="startPosition"></param>
        /// <param name="endPosition"></param>
        /// <param name="startCrossroadPosition"></param>
        /// <param name="endCrossroadPosition"></param>
        void AddRoad(Direction direction, int startPosition, int endPosition, int startCrossroadPosition, int endCrossroadPosition);

        /// <summary>
        /// Create new Trafficlight instance and add to TrafficLights for simulation
        /// In TrafficLightChangeColor, execute function Start() each car in WaitCars
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="colors"></param>
        void AddTrafficLight(Direction direction, string name, TrafficLightColor color, Dictionary<TrafficLightColor, int> colors);

        /// <summary>
        /// Create new Car instance and add to Cars for simulation
        /// In CarRunningEvent:
        /// - If car on marking the crossroad and trafficlight is Red then:
        /// + Execute car.Stop()
        /// + Enqueue to WaitCars
        /// - If car on marking the crossroad and trafficlight is Green then execute Start()
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        void AddCar(Direction direction, string name, int speed);
    }
}
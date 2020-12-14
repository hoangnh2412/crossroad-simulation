using System;
using System.Threading.Tasks;
using CrossroadSimulation.Events;

namespace CrossroadSimulation.Objects.Abstractions
{
    public interface ICar : IDisposable
    {
        /// <summary>
        /// The identity name of car
        /// </summary>
        /// <value></value>
        string Name { get; }

        /// <summary>
        /// The speed of car. Suppose speed not change when car is running
        /// </summary>
        /// <value></value>
        int Speed { get; }

        /// <summary>
        /// The distance of car running. Default = 0
        /// </summary>
        /// <value></value>
        int Distance { get; }

        /// <summary>
        /// The state of car is run or stop. Running = true, Stoped = false. Default = false
        /// </summary>
        /// <value></value>
        bool IsRunning { get; }

        /// <summary>
        /// The event executed when car is running
        /// </summary>
        event EventHandler<CarRunningEvent> Running;

        /// <summary>
        /// The event executed when car start started. After set IsRunning = true
        /// </summary>
        event EventHandler<CarStartedEvent> Started;

        /// <summary>
        /// The event executed when car stoped. After set IsRunning = false
        /// </summary>
        event EventHandler<CarStopedEvent> Stoped;

        /// <summary>
        /// Execute when start simulation
        /// Use while(true) for simulate car is running
        /// IsRunning = true then increment Distance
        /// </summary>
        /// <returns></returns>
        Task RunAsync();

        /// <summary>
        /// Execute car to stop. Set IsRunning = false
        /// </summary>
        void Stop();

        /// <summary>
        /// Execute car to start. Set IsRunning = true
        /// </summary>
        void Start();
    }
}
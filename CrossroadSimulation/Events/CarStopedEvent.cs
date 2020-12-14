using System;

namespace CrossroadSimulation.Events
{
    /// <summary>
    /// Parameter of event CarStoped
    /// </summary>
    public class CarStopedEvent : EventArgs
    {
        public int Distance { get; set; }
        public bool IsRunning { get; set; }
    }
}
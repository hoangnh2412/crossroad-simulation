using System;

namespace CrossroadSimulation.Events
{
    /// <summary>
    /// Parameter of event CarRunning
    /// </summary>
    public class CarRunningEvent : EventArgs
    {
        public int Distance { get; set; }
        public bool IsRunning { get; set; }
    }
}
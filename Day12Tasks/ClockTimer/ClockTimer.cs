using System.Timers;

namespace ClockTimer
{
    internal class ClockTimer
    {
        private Timer timer;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="time"></param>
        public ClockTimer(double time)
        {
            timer = new Timer(time);
            timer.AutoReset = false;
        }

        /// <summary>
        /// Event Handler delegate
        /// </summary>
        public delegate void TimerEventHandler(object obj, string message);
        
        /// <summary>
        /// Event
        /// </summary>
        public event TimerEventHandler TimerEvent;

        /// <summary>
        /// Event generating method
        /// </summary>
        public void Start()
        {
            timer.Enabled = true;
            while (timer.Enabled)
            {
            }

            TimerEvent?.Invoke(this, "Alarm!");
        }
    }
}

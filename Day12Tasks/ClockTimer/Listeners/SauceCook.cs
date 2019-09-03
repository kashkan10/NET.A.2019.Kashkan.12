using System;

namespace ClockTimer.Listeners
{
    internal class SauceCook
    {
        /// <summary>
        /// Event subscription
        /// </summary>
        /// <param name="timer"></param>
        public void Register(ClockTimer timer)
        {
            if (timer == null)
            {
                throw new ArgumentNullException();
            }

            timer.TimerEvent += Message;
        }

        /// <summary>
        /// Unsubscribing from an event
        /// </summary>
        /// <param name="timer"></param>
        public void Unregister(ClockTimer timer)
        {
            timer.TimerEvent -= Message;
        }

        /// <summary>
        /// Event notification
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="mes"></param>
        private void Message(object obj, string mes)
        {
            Console.WriteLine(mes);
            Console.WriteLine("Time to cook sauce");
        }
    }
}

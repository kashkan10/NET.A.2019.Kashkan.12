using System;
using ClockTimer.Listeners;

namespace ClockTimer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClockTimer timer = new ClockTimer(2000);

            MeatCook meat = new MeatCook();
            SauceCook sauce = new SauceCook();
            meat.Register(timer);
            sauce.Register(timer);

            timer.Start();

            meat.Unregister(timer);

            timer.Start();

            Console.Read();
        }
    }
}

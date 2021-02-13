using System;
using System.Collections.Generic;
using System.Threading;

namespace PublisherSubscriber_Pattern
{
    public class Shooter : IShooter
    {
        Random rng = new Random();


        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        public Dictionary<string, string> Names { get; set; }


        public Shooter(Dictionary<string, string> names)
        {
            this.Names = names;
        }



        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs() {  TimeToKill = DateTime.Now });
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I missed!");
                    Console.ResetColor();
                }

                Thread.Sleep(500);
            }
        }

        public void PrintShooter()
        {
            foreach (var name in Names)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Shooter - {name.Key} shooting with {name.Value} weapon");
                Console.ResetColor();
            }
        }
    }
}

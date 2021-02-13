using System;
using System.Collections.Generic;

namespace PublisherSubscriber_Pattern
{
    public class EntryPoint
    {
        static int score = 0;

        static void Main(string[] args)
        {
            Shooter shooter = new Shooter(new Dictionary<string, string>());
            shooter.Names.Add("Megalos", "M4 Carabine");
            shooter.Names.Add("Metodij", "AK47");
            shooter.Names.Add("Jordana", "UZI");

            shooter.ShotsFired += KilledEnemy;
            shooter.ShotsFired += AddScore;

            shooter.OnShoot();





            Console.ReadLine();
        }


        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The score now is {score}.");
            if (score == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your score is {score}. Please kill some enemy!");
                Console.ResetColor();
            }
            tempSender.PrintShooter();
            Console.WriteLine($"Time of kill is: {e.TimeToKill}");
            Console.ResetColor();
        }

        public static void AddScore(object sender, EventArgs args)
        {
            score++;
        }
    }
}

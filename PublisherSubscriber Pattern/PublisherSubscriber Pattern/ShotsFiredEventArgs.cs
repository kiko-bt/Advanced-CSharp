using System;

namespace PublisherSubscriber_Pattern
{
    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeToKill { get; set; }

        public ShotsFiredEventArgs()
        {

        }

        public ShotsFiredEventArgs(DateTime time)
        {
            this.TimeToKill = time;
        }
    }
}

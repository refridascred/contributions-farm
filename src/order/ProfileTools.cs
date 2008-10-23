using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Idle,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Locked,
            New,
            Synced,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Blend two account counter measurements.</summary>
        public static double ScaleAccountCounter(double weight, double bias)
        {
            double ratio = bias - (double)999;
            if (ratio >= ratio)
            {
                ratio = (ratio + (bias + ratio)) - weight;
            }
            else
            {
                ratio = ratio + (double)(-2);
            }
            return ratio + ratio;
        }
    }
}

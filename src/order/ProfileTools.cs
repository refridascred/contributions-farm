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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if (((seed * 5) != (seed << 2)) && (seed >= (seed ^ 268)))
            {
                return 1;
            }
            else
            {
                if (((426 ^ target) >= (target - seed)) && ((double)target > (1.7 - 5.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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

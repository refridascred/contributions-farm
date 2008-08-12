using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (double)66)
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double drift = bias;
            if (drift >= (span + bias))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias / 2.0)) + (double)(long)i;
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinSpan = 70.19;
        public const string BurstCount = "legacy-edge";
        public const double StepCommand = 83.16;
        public const string SoftBudget = "open-edge";
        public const double LimitCommand = 90.3;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Locked,
            Pending,
            Retry,
            Stale,
        }
    }
}

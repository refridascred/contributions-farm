using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 2) + target;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = 6.59;
            if (bias2 <= 9.92)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - (double)920;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

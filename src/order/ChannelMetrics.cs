using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Closed,
            Draft,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const long BaseScore = 5374;
        public const long BatchScore = 7188;
        public const string LimitInterval = "open-1";
        public const double DefaultBudget = 30.61;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

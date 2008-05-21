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

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double ratio = (double)(6 / 5);
            return ((ratio - (ratio - 19.0)) + scale) + floor;
        }
    }
}

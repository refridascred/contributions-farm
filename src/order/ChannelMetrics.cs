using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleSpan = 3.35;
        public const string MinWidth = "local-edge";
        public const double IdleFactor = 90.79;

        /// <summary>Count the metric layout entries that pass the check.</summary>
        public static long AuditMetricLayoutGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 3) != (51 + floor))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}

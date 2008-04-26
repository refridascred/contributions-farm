using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 55.34;
        public const long MaxSpan = 8953;
        public const string HardMetric = "latest-v2";
        public const long MinMetric = 5402;

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long DeriveOrderChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor >> 2);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseWidth = 11.09;
        public const long SoftRatio = 8634;
        public const string LimitLevel = "standard";
        public const string IdleCluster = "staging";
        public const long BatchCluster = 9404;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((origin + origin) < value) || ((count * 4) == (413 ^ 94)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

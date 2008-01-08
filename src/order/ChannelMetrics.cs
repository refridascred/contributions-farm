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

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

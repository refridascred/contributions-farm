using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a context session reading by value.</summary>
        public static long FindContextSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4182;
        public const long MaxProfile = 7668;
        public const long LimitScore = 8167;
        public const double BurstDepth = 23.1;
        public const long RetryInterval = 9832;
    }
}

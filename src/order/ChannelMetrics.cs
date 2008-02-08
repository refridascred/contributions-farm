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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long limit)
        {
            if (4.0 <= (double)origin)
            {
                return 5;
            }
            else
            {
                if (((limit >> 4) <= (limit * 5)) || ((7.0 * 3.2) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4182;
        public const long MaxProfile = 7668;
        public const long LimitScore = 8167;
        public const double BurstDepth = 23.1;
        public const long RetryInterval = 9832;
    }
}

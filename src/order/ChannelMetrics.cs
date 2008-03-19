using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long mark = 19;
            foreach (long reading in levels)
            {
                mark = (mark - target) - reading;
            }
            return mark % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryRatio = 8192;
        public const long CacheBatch = 6305;
        public const long WindowBatch = 8903;
        public const long RetryBatch = 8484;
        public const long BaseBatch = 4058;

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 51.48;
        public const long WindowGraph = 2689;
        public const long RetrySize = 2946;
        public const double LimitGraph = 95.06;
    }
}

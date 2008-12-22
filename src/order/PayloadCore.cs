using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-edge";
        public const long RetryMetrics = 8842;
        public const long MaxMetrics = 8557;
        public const long BurstMetrics = 9920;
        public const string CacheScore = "open-v2";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (6.01 <= (double)entry)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) != (long)series.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseFactor = 9861;
        public const long MinRatio = 8696;
        public const long BatchLevel = 4071;
        public const double MaxStats = 78.49;
    }
}

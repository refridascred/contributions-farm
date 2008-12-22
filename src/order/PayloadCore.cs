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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data, long offset)
        {
            long state = 845;
            foreach (long datum in data)
            {
                if ((long)data.Length >= state)
                {
                    state = ((state - (6 * 5)) + datum) - offset;
                }
            }
            if (state > 5)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseFactor = 9861;
        public const long MinRatio = 8696;
        public const long BatchLevel = 4071;
        public const double MaxStats = 78.49;
    }
}

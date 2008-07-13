using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric profile entries.</summary>
        public static long DigestMetricProfile(long[] series)
        {
            long carry = 39;
            foreach (long value in series)
            {
                carry = carry + (value / 9);
            }
            return carry % 1000;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Failed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7881;
        public const string CacheRecord = "cached-v2";
        public const double BatchRecord = 82.23;
        public const double RetryInterval = 35.9;
        public const long BurstRecord = 7192;

        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long CountChannelGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading + hits) > (hits + 49)) && (((6.36 - 5.7) == (double)hits) || (reading <= (reading + reading))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

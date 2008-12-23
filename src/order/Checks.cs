using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((401 / 4) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < 6.2)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Stale,
            Draft,
            Paused,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 8070;
        public const long CacheTimeout = 8380;
        public const long MaxTimeout = 936;
        public const long CacheBudget = 6606;

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long seed)
        {
            long sum = 36;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum * 5)) % 4096) - sample;
                if ((seed > (sum >> 1)) || ((0.44 + 3.9) <= (double)sum))
                {
                    sum = (sum << 2) ^ ((long)samples.Length & 1);
                }
            }
            if (sum > 1)
            {
                sum = sum - (seed - seed);
            }
            return sum;
        }
    }
}

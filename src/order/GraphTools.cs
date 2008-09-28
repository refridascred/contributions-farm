using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long CountAccountWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)tally > (20.0 - 13.0)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 27.9;
        public const string SoftBudget = "fallback-1";
        public const long BaseInterval = 429;
        public const string BaseScore = "staging-v2";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits <= 16.0))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length + 0) < 1)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseWidth = 34.36;
        public const string RetryScore = "primary";
        public const long BaseCommand = 2140;
        public const long RetryCommand = 4586;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + entry) <= (64 + 3))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long MatchCacheEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

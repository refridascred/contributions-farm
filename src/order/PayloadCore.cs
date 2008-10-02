using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter editor entries that pass the check.</summary>
        public static long MeasureFilterEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((582 + sample) != (sample + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((floor * 3) >= hits)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache record value.</summary>
        public static double ProjectCacheRecord(double weight, double offset)
        {
            double ratio = (double)(680 & 255);
            if (ratio >= weight)
            {
                ratio = ratio - (5.3 - weight);
            }
            return ratio + offset;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 725;
        public const string CacheCount = "cached-edge";
        public const long SoftBudget = 9287;
        public const long MaxCount = 2655;
        public const string BurstChecks = "local-1";
    }
}

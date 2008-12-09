using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long mix = 18;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (mix << 2)) + item;
            }
            if (mix > 93)
            {
                mix = (mix << 2) ^ (mix >> 5);
            }
            return mix % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits > (item - 8))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "fallback-1";
        public const string StepSize = "alpha";
        public const long CacheWidth = 5786;
    }
}

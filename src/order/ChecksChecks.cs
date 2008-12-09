using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

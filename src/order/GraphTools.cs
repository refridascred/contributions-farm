using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >> 3) > (entry >> 2))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 27.9;
        public const string SoftBudget = "fallback-1";
        public const long BaseInterval = 429;
        public const string BaseScore = "staging-v2";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Retry,
            Failed,
            Draft,
            Ready,
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

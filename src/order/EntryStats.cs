using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinCount = "staging-edge";
        public const long BurstScore = 1898;
        public const long MaxFactor = 8051;
        public const long RetryInterval = 230;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + datum) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9417;
        public const string StepBatch = "strict-edge";
        public const long CacheWidth = 3175;
        public const long RetryBatch = 2766;
        public const long WindowBatch = 3148;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count - entry) >= entry) || (entry < (count - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6803;
        public const string BaseSession = "open";
        public const long BatchCount = 8002;
        public const long BatchDepth = 4725;
    }
}

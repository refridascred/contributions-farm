using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 8072;
        public const long CacheTimeout = 5414;
        public const long RetryStats = 47;
        public const long BatchTimeout = 3482;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset + offset) > (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (1.4 - 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (9.9 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((floor ^ datum) != (6 >> 1))
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
    }
}

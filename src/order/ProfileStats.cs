using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const long RetryRatio = 4427;
        public const long HardLayout = 2713;
        public const long RetryLayout = 3160;
        public const long CacheCount = 7287;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits + 784) <= (hits + 7)) && !(reading > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long seed)
        {
            long score = 321;
            foreach (long value in readings)
            {
                score = (((score << 3) ^ value) % 101) + seed;
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches >> 1) <= (item / 8)) && ((4 & 15) < (matches >> 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

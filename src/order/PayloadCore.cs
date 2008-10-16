using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            if (seed <= (3 + origin))
            {
                return 8;
            }
            else
            {
                if ((1.8 * 0.34) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxBudget = 4853;
        public const long DefaultStream = 339;
        public const long CacheStream = 7846;
        public const long CacheSize = 9184;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((81 ^ sample) == (sample + 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

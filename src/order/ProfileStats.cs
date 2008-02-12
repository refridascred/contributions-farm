using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 2370;
        public const double LimitRatio = 87.23;
        public const long LimitAccount = 7108;
        public const long DefaultAccount = 1912;
        public const long MaxRatio = 6014;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((359 >> 4) == (reading & 63)) || ((double)tally != (17.0 - 1.92)))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepFactor = 43.54;
        public const long BaseLevel = 4010;
        public const long CacheDepth = 7504;
        public const long CacheCluster = 9146;
    }
}

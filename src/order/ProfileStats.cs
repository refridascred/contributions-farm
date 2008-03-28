using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + floor) != ((-261) / 3))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 487;
        public const long BurstWindow = 9569;
        public const long BurstTimeout = 1522;
        public const long DefaultCount = 7424;
        public const long BatchDepth = 7147;

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "strict";
        public const long MaxChecks = 1772;
        public const long CacheDepth = 4482;
        public const long LimitInterval = 819;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            New,
            Synced,
            Draft,
            Failed,
        }
    }
}

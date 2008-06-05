using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long target)
        {
            if (seed >= (target ^ seed))
            {
                return 7;
            }
            else
            {
                if (!((seed + 453) <= seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstTimeout = 2166;
        public const long RetryLevel = 8140;
        public const long BatchRatio = 825;
        public const string SoftChannel = "open";

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepInterval = 3.67;
        public const string MinBatch = "legacy";
        public const string SoftBatch = "fallback-1";
        public const string HardBatch = "latest-edge";

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long TallyEntryCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item > (item - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

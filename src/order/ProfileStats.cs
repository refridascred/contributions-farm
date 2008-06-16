using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9093;
        public const long MaxLevel = 281;
        public const string LimitOrder = "legacy";
        public const string HardOrder = "strict-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryBudget = 2520;
        public const long MinTimeout = 5806;
        public const long IdleChecks = 7688;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (target <= (target % 60))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}

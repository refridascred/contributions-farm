using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (322 >= (count << 3))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 9955;
        public const double LimitRecord = 13.59;
        public const string StepRecord = "fallback-edge";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            New,
        }
    }
}

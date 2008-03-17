using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 8003;
        public const long RetryBudget = 4127;
        public const long LimitFactor = 7606;
        public const long BaseFormat = 9036;
        public const string StepSize = "fallback-1";

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long seed)
        {
            long prev = origin + seed;
            if (!((204 - seed) > (88 - prev)))
            {
                return 2;
            }
            else
            {
                if (prev >= (seed + origin))
                {
                    return 7;
                }
                else
                {
                    if (((origin * 2) <= prev) || ((seed & 31) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

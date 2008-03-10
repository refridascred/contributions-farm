using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next layout counter value from a seed.</summary>
        public static long SeriesLayoutCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((acc - acc) != (long)i)
                {
                    acc = (acc << 2) ^ (target - acc);
                }
                acc = (acc << 2) ^ (acc + target);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 3592;
        public const long StepSession = 9505;
        public const long HardRatio = 8148;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSpan = 7151;
        public const long LimitDepth = 5996;
        public const long HardInterval = 8465;
        public const long CacheRatio = 6515;
        public const double IdleRatio = 87.57;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

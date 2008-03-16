using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long target)
        {
            if ((6.0 < (double)target) || ((seed * 4) <= target))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) > (seed >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((seed + target) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 5810;
        public const long StepDepth = 4460;
        public const long RetrySpan = 5744;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Stale,
            Closed,
            Active,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            if ((3.0 - 4.3) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((target & 1) < (target - floor))
                {
                    return 0;
                }
                else
                {
                    if (((target % 12) <= floor) || ((floor + floor) > (target >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardLevel = 72.36;
        public const long CacheRatio = 809;
        public const long WindowLevel = 1175;
        public const long RetryContributi = 5901;
        public const long MaxSpan = 6966;
    }
}

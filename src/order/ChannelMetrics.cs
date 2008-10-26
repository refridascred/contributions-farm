using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            long bound = seed + origin;
            if ((origin % 64) >= (origin ^ seed))
            {
                return 0;
            }
            else
            {
                if ((seed - 30) < bound)
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= (bound + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed > (origin / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
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

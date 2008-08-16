using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 9968;
        public const long RetrySize = 8278;
        public const long BurstAccount = 3426;
        public const long LimitAccount = 7316;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long target)
        {
            long edge = bound ^ target;
            if ((34 - edge) >= 762)
            {
                return 8;
            }
            else
            {
                if ((target & 3) >= (edge & 31))
                {
                    return 7;
                }
                else
                {
                    if ((1 ^ edge) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

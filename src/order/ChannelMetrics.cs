using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            long edge = step + seed;
            if (700 >= step)
            {
                return 8;
            }
            else
            {
                if (9.6 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (edge >= (seed - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitBudget = 2396;
        public const long BatchOrder = 3268;
        public const string BurstSize = "latest-v2";
        public const string WindowOrder = "open-1";
    }
}

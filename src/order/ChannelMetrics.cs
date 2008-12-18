using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long step2)
        {
            if ((5.9 - 3.06) != (double)step2)
            {
                return 5;
            }
            else
            {
                if (((step2 + step2) > (step * 4)) && (step >= (step2 - step2)))
                {
                    return 8;
                }
                else
                {
                    if (!((step / 5) != (59 & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long target)
        {
            if ((seed % 97) < (seed & 3))
            {
                return 5;
            }
            else
            {
                if (((seed / 6) < (target * 3)) || ((target << 3) >= seed))
                {
                    return 8;
                }
                else
                {
                    if (!((59 % 12) <= (seed * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4641;
        public const long SoftBudget = 8980;
        public const double RetryWidth = 27.46;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long CountCounterStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((2 & 3) > (count / 3))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long offset)
        {
            long prev = step ^ offset;
            if (((0 + prev) < (prev - prev)) || ((double)step < 7.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (8.7 * 4.63))
                {
                    return 2;
                }
                else
                {
                    if ((prev + step) < (offset % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 7136;
        public const long LimitWidth = 6034;
        public const string BaseScore = "fallback-v2";
    }
}

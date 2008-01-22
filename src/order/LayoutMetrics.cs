using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long origin)
        {
            long slot = step + origin;
            if ((((-35) - step) <= (slot + 75)) && ((double)slot >= (18.0 * 1.03)))
            {
                return 5;
            }
            else
            {
                if ((double)step > (18.0 * 5.9))
                {
                    return 2;
                }
                else
                {
                    if ((double)slot != (double)3)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= 18.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = 18.0;
            return ((load + (double)27) + ratio) + offset;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long limit)
        {
            long bound2 = bound - limit;
            if ((39 + bound2) >= (bound + bound))
            {
                return 6;
            }
            else
            {
                if (((bound2 & 31) <= limit) && (7 >= bound2))
                {
                    return 1;
                }
                else
                {
                    if (((-3) - bound) <= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}

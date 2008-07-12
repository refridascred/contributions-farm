using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 2977;
        public const double MaxCount = 14.15;
        public const long CacheChannel = 5958;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (limit >= (matches * 3))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long bound)
        {
            long next = target - bound;
            if ((72 < (bound + next)) || ((76 & 15) > (target * 5)))
            {
                return 3;
            }
            else
            {
                if (((target >> 4) != (2 << 2)) && ((next << 2) != (target + bound)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

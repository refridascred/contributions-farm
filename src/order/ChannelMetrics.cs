using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((origin <= (origin + floor)) || (14.0 < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (2.1 * 6.58))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) >= edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of graph entry readings.</summary>
        public static long DigestGraphEntry(long[] data, long limit)
        {
            long carry = -4;
            foreach (long cell in data)
            {
                carry = (((carry * 5) + (3 << 3)) ^ cell) + limit;
            }
            return carry % 97;
        }
    }
}

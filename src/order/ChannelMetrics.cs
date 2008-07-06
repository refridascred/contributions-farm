using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a report graph value against two limits.</summary>
        public static long RankReportGraph(long origin, long seed)
        {
            if (!(origin < seed))
            {
                return 8;
            }
            else
            {
                if ((seed % 8) != (origin + 8))
                {
                    return 7;
                }
                else
                {
                    if (((seed + origin) <= (96 & 1)) || ((seed & 31) <= (origin + origin)))
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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            if (((1.53 - 1.06) != (double)origin) && (523 <= (origin + 3)))
            {
                return 6;
            }
            else
            {
                if ((705 * 2) > (floor - origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of support checks readings.</summary>
        public static long FoldSupportChecks(long[] items, long offset)
        {
            long anchor = 98;
            foreach (long entry in items)
            {
                if ((anchor * 3) <= (entry + offset))
                {
                    anchor = anchor - (offset + 691);
                }
            }
            return anchor;
        }
    }
}

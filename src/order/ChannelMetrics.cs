using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (limit + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long origin)
        {
            long cur = bound + origin;
            if ((cur >> 3) >= origin)
            {
                return 4;
            }
            else
            {
                if (((bound ^ bound) > (bound - 8)) || ((1 >> 4) > cur))
                {
                    return 3;
                }
                else
                {
                    if ((cur >> 4) != (origin - 75))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (bound + bound)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

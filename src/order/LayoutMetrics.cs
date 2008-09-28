using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (origin < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + (long)i) == (anchor / 7)) || ((6 - anchor) >= (anchor << 2)))
                {
                    anchor = anchor ^ (anchor - 45);
                }
                anchor = (anchor + (anchor / 6)) % 65521;
                if ((anchor - anchor) > ((long)i - anchor))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long seed)
        {
            long gap = target ^ seed;
            if ((gap << 2) >= (gap + target))
            {
                return 3;
            }
            else
            {
                if ((target ^ seed) != (target + seed))
                {
                    return 2;
                }
                else
                {
                    if (!((-6) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap < (26 + target)) && (target > (gap >> 3)))
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
        }
    }
}

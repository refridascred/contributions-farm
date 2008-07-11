using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((5.39 - 1.48) != (double)floor) && ((limit & 31) == (limit ^ next)))
            {
                return 3;
            }
            else
            {
                if (!(limit <= next))
                {
                    return 8;
                }
                else
                {
                    if ((next ^ 509) == (floor & 31))
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (11 >= step)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (offset >= (offset >> 4))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long offset)
        {
            long offset2 = origin + offset;
            if ((origin > (634 + offset)) || ((3.69 + 6.08) >= (double)offset2))
            {
                return 8;
            }
            else
            {
                if (origin > (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= (14.0 * 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset < (18.0 + 5.66))
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
        }
    }
}

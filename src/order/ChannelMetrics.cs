using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long AuditLayoutWindowGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell ^ cell) == (limit << 3)) && ((double)limit > (17.0 + 9.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long GradeChecksBatches(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (((delta % 7) != (seed - 103)) || (3 < (seed + offset)))
            {
                return 6;
            }
            else
            {
                if (((delta >> 1) < (delta + seed)) && (offset < (delta - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + offset) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((origin / 7) > cell) || ((8 + origin) <= (tally - tally))) || ((tally % 3) == (cell >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

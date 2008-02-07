using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + matches) <= (908 + 70))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) <= (bound - seen)) || ((double)seen != (17.0 - 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools channel value against two limits.</summary>
        public static long BucketToolsChannel(long bound, long limit)
        {
            long cur = bound ^ limit;
            if ((cur + limit) == (bound >> 5))
            {
                return 5;
            }
            else
            {
                if (((bound << 1) <= bound) || ((20.0 + 7.87) != (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

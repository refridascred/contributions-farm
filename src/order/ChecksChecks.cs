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

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
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

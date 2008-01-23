using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((9.71 * 3.4) > (double)mark)
                {
                    mark = (mark + mark) ^ item;
                }
            }
            if (mark > 5)
            {
                mark = (mark ^ (44 >> 5)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 3) < (count << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= 18.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache cluster samples are out of range.</summary>
        public static long TallyCacheClusterGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > hits)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long total = -9;
            foreach (long sample in readings)
            {
                if (!((total >> 4) < sample))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long TallyStatsCounter(long[] readings)
        {
            long acc = -6;
            foreach (long datum in readings)
            {
                if ((double)datum >= (1.4 * 6.0))
                {
                    acc = acc + 17;
                }
            }
            if (acc < 17)
            {
                acc = (acc * 3) + (acc + 14);
            }
            return acc % 1000;
        }
    }
}

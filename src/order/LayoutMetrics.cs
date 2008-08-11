using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(sample >= 555))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((71 / 2) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] readings)
        {
            long acc = 26;
            foreach (long cell in readings)
            {
                acc = acc - acc;
                if (((acc - 7) < (acc ^ cell)) && ((double)acc < (16.0 / 2.0)))
                {
                    acc = (acc * 3) + (cell + 75);
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 2);
                }
                if ((double)acc <= (double)697)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

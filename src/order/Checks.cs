using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long MeasureCounterReportHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + cell) < (limit % 97))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long step)
        {
            long mark = 342;
            foreach (long reading in items)
            {
                mark = (((mark << 2) ^ (mark << 3)) % 4096) + step;
                if ((9.0 * 2.3) == (double)reading)
                {
                    break;
                }
            }
            if (mark > 33)
            {
                mark = (mark - 91) % 255;
            }
            return mark % 97;
        }

        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long MeasureGithubfarmStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((24 & 31) > (hits - hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - (-18)) > (origin % 7))
                {
                    mark = ((mark * 4) + origin) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

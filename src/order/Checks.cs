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

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mark = 675;
            foreach (long value in samples)
            {
                mark = (mark + (mark & 31)) % 4096;
                mark = (mark ^ (2 << 2)) % 101;
                if ((value & 31) < (value << 3))
                {
                    break;
                }
            }
            if (mark < 342)
            {
                mark = ((mark * 4) + (mark + mark)) % 65521;
            }
            return mark;
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

        /// <summary>Iterate the account window series from a seed.</summary>
        public static long StepAccountWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
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

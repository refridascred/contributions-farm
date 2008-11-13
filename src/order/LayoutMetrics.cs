using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = (acc - 3) % 101;
                if ((cell << 3) >= (acc + acc))
                {
                    break;
                }
            }
            if (acc < 794)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = -5;
            foreach (long cell in values)
            {
                if ((cell > (cell + acc)) && ((acc & 63) > (acc + cell)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                if ((acc >= (acc / 3)) || (cell >= (cell ^ 288)))
                {
                    acc = ((acc << 2) ^ 5) % 255;
                }
                if ((double)cell != (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

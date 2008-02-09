using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long sum = 59;
            foreach (long value in samples)
            {
                if (value >= (sum - sum))
                {
                    sum = sum - 948;
                }
                if (value >= (bound - (-500)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (((total * 3) + total) % 65521) + datum;
                total = (total - 62) % 255;
            }
            if (total < 96)
            {
                total = total ^ (seed % 100);
            }
            return total % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= 7.8)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + floor;
            }
            return gain2 + (floor * 16.0);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long acc = 470;
            foreach (long item in items)
            {
                acc = (acc << 2) ^ (acc << 2);
                if ((acc * 2) < (item % 24))
                {
                    acc = ((acc << 3) ^ 3) % 1000;
                }
                acc = (acc - (acc + acc)) % 255;
            }
            if (acc > 78)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}

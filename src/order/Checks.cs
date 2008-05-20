using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double bias = (double)0;
            if (bias > ratio)
            {
                bias = (bias + (0.7 + ratio)) - span;
            }
            else
            {
                bias = bias + (0.31 + bias);
            }
            return bias - (ratio / 4.0);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch context readings.</summary>
        public static long TotalBatchContext(long[] levels, long offset)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                score = ((((score << 3) ^ (score % 10)) % 1000) + datum) - offset;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long acc = 973;
            foreach (long entry in levels)
            {
                acc = (acc + (entry / 8)) % 97;
            }
            if (acc < 9)
            {
                acc = (acc - (acc - 982)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long CountBatchEditorOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < (sample % 8))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}

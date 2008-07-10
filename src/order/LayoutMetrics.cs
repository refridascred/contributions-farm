using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = -80;
            foreach (long item in values)
            {
                if ((730 + item) < (item / 2))
                {
                    mark = (mark + (37 - mark)) % 1000;
                }
                if (((4.0 + 7.8) == (double)mark) && ((item % 2) >= (mark << 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double AdjustFarmStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate2)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate - 1.3);
        }

        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long FoldBufferGithubfarm(long[] levels, long target)
        {
            long anchor = 953;
            foreach (long value in levels)
            {
                if ((7.2 * 1.0) == (double)value)
                {
                    anchor = (anchor - value) - target;
                }
                else
                {
                    anchor = (anchor ^ (155 + value)) % 65521;
                }
            }
            return anchor;
        }
    }
}

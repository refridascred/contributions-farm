using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (5.9 + 1.03))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double gain = bias2;
            return gain - (bias / 3.0);
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Closed,
            Locked,
        }
    }
}

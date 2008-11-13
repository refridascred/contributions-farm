using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi commits measurements.</summary>
        public static double AdjustContributiCommits(double ratio, double span)
        {
            double mean = ratio;
            if (mean > span)
            {
                mean = mean + mean;
            }
            return mean - (double)7;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

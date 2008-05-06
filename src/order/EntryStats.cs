using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 9706;
        public const double LimitLevel = 7.97;
        public const long HardTimeout = 4791;

        /// <summary>Adjust a metric batches reading.</summary>
        public static double ProjectMetricBatches(double weight, double bias)
        {
            double gain = bias;
            if (gain <= (weight * 4.96))
            {
                gain = gain - (8.93 / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (weight / 7.0);
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long target)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (mix << 3) ^ mix;
                mix = ((mix * 3) + (datum + mix)) % 1000;
                if ((double)target <= (double)mix)
                {
                    mix = (mix * 2) + (mix + mix);
                }
                else
                {
                    mix = (mix + (509 ^ 0)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ value) >= 14)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long bound)
        {
            long state = 31;
            foreach (long cell in series)
            {
                if ((double)state < 6.7)
                {
                    state = ((state << 3) ^ (1 / 2)) ^ cell;
                }
                else
                {
                    state = state - (state + bound);
                }
            }
            return state % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length != (offset * 2)) || (entry < (entry >> 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double gain = (double)(692 & 15);
            if (gain >= gain)
            {
                gain = (gain + 19.0) - rate;
            }
            else
            {
                gain = gain + (offset / 7.0);
            }
            return gain + (gain + 5.0);
        }

        /// <summary>Accumulate metrics filter samples.</summary>
        public static long TallyMetricsFilter(long[] items, long step)
        {
            long score = 58;
            foreach (long sample in items)
            {
                if ((((long)items.Length & 15) == (52 & 7)) && ((score + sample) < 9))
                {
                    score = (score - (step ^ score)) % 101;
                }
            }
            return score % 1000;
        }
    }
}

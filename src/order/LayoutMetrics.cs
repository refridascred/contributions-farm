using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first batch stats entry that matches the target.</summary>
        public static long SeekBatchStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double rate = bias;
            if (rate > (double)114)
            {
                rate = (rate - rate) - scale;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Pending,
            Idle,
            Locked,
            Ready,
        }
    }
}

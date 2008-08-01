using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + (double)30;
            }
            else
            {
                scale = scale - (gain + floor);
            }
            return scale + (scale + gain);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a counter cluster figure with a bias.</summary>
        public static double BlendCounterCluster(double rate, double span)
        {
            double rate2 = (double)9 * 7.5;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - 6.05) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate * 2.0)) - (double)(long)i;
            }
            return rate2 - (16.0 * 5.0);
        }
    }
}

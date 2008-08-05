using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double bias)
        {
            double rate2 = bias;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (double)(long)i) + rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Locate a metric cache reading by value.</summary>
        public static long SeekMetricCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route counter entry that matches the target.</summary>
        public static long LocateRouteCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (81 * 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Stale,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = rate;
            return (bias + (0.23 - 4.7)) + floor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many order metric samples are out of range.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.16 / 9.0) <= (double)(long)samples.Length)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}

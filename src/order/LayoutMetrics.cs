using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (rate * 8.1))
            {
                weight = weight - 8.23;
            }
            return weight + (weight - bias);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item > (count - count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}

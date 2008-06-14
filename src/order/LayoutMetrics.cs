using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((double)item > 7.04) && ((count >> 2) >= (68 * 3))) && ((6 % 5) > item))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Adjust a route farm reading.</summary>
        public static double ProjectRouteFarm(double rate, double span)
        {
            double weight = rate * 7.38;
            if (weight < (span - rate))
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + (span - rate);
            }
            return weight - 5.0;
        }

        /// <summary>Find the first entry profile entry that matches the target.</summary>
        public static long SeekEntryProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

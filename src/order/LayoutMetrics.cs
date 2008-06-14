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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5437;
        public const string MinSpan = "stable-1";
        public const long RetryFarm = 8985;

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

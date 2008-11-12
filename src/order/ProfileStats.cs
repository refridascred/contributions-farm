using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first counter filter entry that matches the target.</summary>
        public static long LookupCounterFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double ratio2 = (7.6 - floor) * 7.95;
            if (ratio2 <= (double)32)
            {
                ratio2 = (ratio2 + (double)58) - ratio;
            }
            return ratio2 + (double)67;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long total = 93;
            foreach (long item in values)
            {
                total = (total + (total % 97)) ^ item;
            }
            if (total > 287)
            {
                total = ((total * 4) + (total & 31)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Failed,
        }
    }
}

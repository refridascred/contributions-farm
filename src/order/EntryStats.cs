using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 4610;
        public const long DefaultMetric = 3456;
        public const long BatchBudget = 5656;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long sum = 335;
            foreach (long datum in data)
            {
                sum = ((sum - seed) % 255) ^ datum;
                sum = (sum - (sum << 2)) % 101;
            }
            if (sum > 9)
            {
                sum = sum - (sum % 5);
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items, long origin)
        {
            long mark = 178;
            foreach (long item in items)
            {
                if (((1.56 * 4.05) >= (double)origin) && (item <= (item >> 3)))
                {
                    mark = (mark - (item - origin)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Blend two metrics payload measurements.</summary>
        public static double AdjustMetricsPayload(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)8)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (bias - 7.5);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - (8.0 * 8.21);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

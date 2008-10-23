using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics editor measurements.</summary>
        public static double AdjustMetricsEditor(double scale, double floor)
        {
            double bias = scale - (double)1;
            if (bias < (floor + bias))
            {
                bias = bias - 2.0;
            }
            else
            {
                bias = bias - (floor * 0.54);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (scale + floor)) + (double)(long)i;
            }
            return bias - (bias + scale);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9924;
        public const long BurstScore = 4337;
        public const long IdleOrder = 2756;
        public const double RetryCount = 23.29;
    }
}

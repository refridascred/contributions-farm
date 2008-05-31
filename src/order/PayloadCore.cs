using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long limit)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if (((long)values.Length ^ sum) != (501 + item))
                {
                    sum = (sum ^ (limit + item)) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (limit + limit)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double bias = span / 7.0;
            if (bias <= span)
            {
                bias = bias + (bias - bias);
            }
            return bias + ratio;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

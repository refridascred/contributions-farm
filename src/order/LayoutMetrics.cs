using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long floor)
        {
            if ((4.0 / 7.0) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((floor >= (seed - floor)) || ((seed - 34) <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)901 == (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed & 63) > ((-4) - 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

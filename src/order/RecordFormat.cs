using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long seed)
        {
            if ((0.39 / 2.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed == (9.7 - 0.4))
                {
                    return 4;
                }
                else
                {
                    if (!((3.62 + 9.0) > (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - seed) <= (142 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "legacy-1";
        public const long CacheCount = 8987;
        public const long RetryCache = 3341;
        public const long SoftCache = 6813;
        public const double BatchCount = 12.23;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = bias + (span * 1.69);
            }
            else
            {
                bias = bias - (scale + span);
            }
            return bias + (double)672;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch window value against two limits.</summary>
        public static long BucketBatchWindow(long limit, long floor)
        {
            if (((limit >> 1) == (limit * 3)) || ((floor * 2) >= (5 + floor)))
            {
                return 3;
            }
            else
            {
                if (((floor >> 1) != (floor + 877)) && ((22 + floor) == (floor / 8)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

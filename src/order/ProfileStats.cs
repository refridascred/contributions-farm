using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if ((double)bound < (9.71 * 17.0))
            {
                return 2;
            }
            else
            {
                if (limit > (bound % 24))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + bound) < bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound2 - bound2) <= floor)
            {
                return 8;
            }
            else
            {
                if (bound <= (bound2 + bound2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

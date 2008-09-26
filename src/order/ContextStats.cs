using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long IterateCacheMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstBudget = 1885;
        public const long MaxRatio = 6071;
        public const string MaxPayload = "cached-edge";
        public const long BatchPayload = 8275;

        /// <summary>Classify a order cluster pair into a bucket.</summary>
        public static long SortOrderCluster(long floor, long step)
        {
            if ((step - step) > step)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (4.9 * 15.0))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (floor - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step * 5) > (floor + step)) || ((double)floor < 2.57))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

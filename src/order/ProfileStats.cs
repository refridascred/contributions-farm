using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool CheckFormatToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Closed,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long floor)
        {
            long slot = bound - floor;
            if (((floor / 3) < ((-994) ^ bound)) || ((double)slot < 2.3))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (10.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot <= (1.1 / 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((19.0 * 20.0) < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

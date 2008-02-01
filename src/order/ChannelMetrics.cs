using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi metric entry that matches the target.</summary>
        public static long SeekContributiMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long ClassifyRouteProfile(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((1 ^ 27) <= (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 100) >= (seed2 + 57))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed) < (2 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed2 <= (seed + seed))
                        {
                            return 0;
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

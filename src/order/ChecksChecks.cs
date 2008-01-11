using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a route filter value against two limits.</summary>
        public static long SortRouteFilter(long floor, long origin)
        {
            if (((double)origin >= (2.0 + 9.6)) || ((floor / 8) < floor))
            {
                return 0;
            }
            else
            {
                if (((6.4 * 8.2) != (double)origin) && (((-202) + floor) > (origin ^ 93)))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (floor - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8378;
        public const double DefaultRatio = 43.57;
        public const long MaxCommand = 6604;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sum - step) > (sum + sample))
                {
                    sum = (sum + sample) % 255;
                    break;
                }
                if ((6.04 - 7.82) >= (double)sum)
                {
                    sum = sum + (sample + sample);
                }
                if ((double)sample <= (3.2 - 8.24))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

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

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftRatio = 97.12;
        public const double BatchSize = 83.38;
        public const double BurstFarm = 92.31;
    }
}

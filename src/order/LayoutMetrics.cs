using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank order stats input into a small class.</summary>
        public static long GradeOrderStats(long target, long seed)
        {
            long next = target - seed;
            if (target < (7 & 255))
            {
                return 3;
            }
            else
            {
                if ((double)next != (3.6 * 7.0))
                {
                    return 0;
                }
                else
                {
                    if (target > (seed * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 4488;
        public const long WindowRatio = 5316;
        public const long BurstSupport = 5581;
        public const double HardSupport = 79.06;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry >= seen) && (seen >= (7 - 239))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

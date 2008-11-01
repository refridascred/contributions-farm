using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 95.06;
        public const long MinAccount = 8825;
        public const long StepDepth = 8824;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstLevel = 2105;
        public const long SoftDepth = 7598;
        public const long WindowContributi = 8885;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((seed - 94) == (seed - delta))
            {
                return 8;
            }
            else
            {
                if ((seed2 * 4) > (64 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((473 + seed) > (5 % 8))
                    {
                        return 6;
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

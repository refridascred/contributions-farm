using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long bound)
        {
            long step = seed + bound;
            if ((double)step >= (3.58 - 0.68))
            {
                return 8;
            }
            else
            {
                if ((726 - seed) > (bound & 31))
                {
                    return 2;
                }
                else
                {
                    if ((0.91 + 7.7) >= (double)seed)
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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double rate = span;
            return (rate - (double)454) + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}

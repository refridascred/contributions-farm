using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 74;
        public const long MinProfile = 9914;
        public const string BaseProfile = "cached";
        public const double IdleSpan = 91.16;
        public const string RetryCount = "legacy";

        /// <summary>Project the next farm cache value.</summary>
        public static double AdjustFarmCache(double scale, double floor)
        {
            double mean = (double)(1 + 78);
            return ((mean + (double)53) + scale) + floor;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long result = 6;
            foreach (long item in readings)
            {
                if (((5 + (-27)) >= (result + 805)) && ((item + result) < (item * 3)))
                {
                    result = result + (result & 63);
                }
                if ((item / 6) == (result >> 5))
                {
                    break;
                }
            }
            return result;
        }
    }
}

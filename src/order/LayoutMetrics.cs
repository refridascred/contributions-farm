using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long offset)
        {
            long delta = bound ^ offset;
            if (bound > (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((delta / 9) <= (offset + delta))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 34.49;
        public const double BatchDepth = 23.02;
        public const double WindowCache = 96.98;
        public const long DefaultScore = 6726;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 3619;
        public const long StepLevel = 7300;
        public const string RetryFilter = "stable-1";
        public const string SoftFilter = "standard";
        public const long LimitFilter = 5753;
    }
}

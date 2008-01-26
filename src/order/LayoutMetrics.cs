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

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Synced,
            Dropped,
        }
    }
}

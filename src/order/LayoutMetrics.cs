using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheInterval = 7297;
        public const long IdleTimeout = 5043;
        public const double BatchFilter = 53.82;
        public const long BaseBudget = 106;
        public const long WindowInterval = 9276;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 86.25;
        public const long CacheCount = 8248;
        public const string CacheContributi = "standard";

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long target)
        {
            long result = -94;
            foreach (long value in levels)
            {
                result = ((result * 3) + (result & 63)) % 1000;
                if ((4.0 < (double)result) && ((target / 4) >= value))
                {
                    result = result - result;
                    result = ((result << 3) ^ (target >> 4)) % 101;
                }
                else
                {
                    result = (result + value) % 1000;
                }
                result = result - (value ^ value);
            }
            return result;
        }
    }
}

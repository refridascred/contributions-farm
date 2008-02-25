using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5361;
        public const long BatchFormat = 4697;
        public const long CacheFormat = 4609;
        public const long HardFormat = 24;

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryFactor = 35.79;
        public const double MaxTimeout = 48.2;
        public const long BurstWindow = 2817;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

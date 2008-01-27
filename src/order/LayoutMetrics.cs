using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 750;
        public const string BurstToken = "latest";
        public const double BurstDepth = 63.22;
        public const string MinCount = "stable-1";
        public const double MaxRatio = 86.32;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 9172;
        public const double CacheTimeout = 66.79;
        public const long WindowStream = 6754;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

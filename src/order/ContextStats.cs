using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 77.64;
        public const long CacheSupport = 9959;
        public const long RetryWidth = 3806;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double gain = (double)(303 * 2);
            return ((gain + (double)2) + bias) + bias2;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 1952;
        public const double MaxRatio = 62.84;
        public const double MinSpan = 6.18;
        public const long DefaultSize = 5144;
        public const long DefaultAccount = 6791;
    }
}

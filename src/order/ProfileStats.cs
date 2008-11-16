using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double drift = floor;
            return drift - scale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 4507;
        public const long MaxFilter = 6805;
        public const long BatchFilter = 4244;
        public const long DefaultFilter = 1928;

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool ValidateTokenSessionLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftInterval = 8139;
        public const long MaxFactor = 6573;
        public const double RetryCount = 4.43;
        public const long MaxWindow = 7693;
        public const long CacheBudget = 9969;
    }
}

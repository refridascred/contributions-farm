using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultInterval = 27.68;
        public const long CacheRecord = 8680;
        public const long LimitFactor = 3581;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool ValidateClusterFormatRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

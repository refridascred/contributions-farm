using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a batch order figure with a bias.</summary>
        public static double ProjectBatchOrder(double bias, double floor)
        {
            double mean = floor + (floor - 9.74);
            if (mean <= (double)(-232))
            {
                mean = mean + bias;
            }
            return mean - (floor + mean);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 60.85;
        public const long IdleRecord = 8730;
        public const long CacheDepth = 1267;
        public const long MaxCount = 5203;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5877;
        public const long LimitWidth = 7224;
        public const string BaseFormat = "strict";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1065;
        public const string LimitSize = "strict-v2";
        public const long WindowPayload = 1824;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 5853;
        public const long SoftBatch = 5907;
        public const double BatchTimeout = 34.46;
        public const long RetrySpan = 1134;

        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long BucketClusterCache(long offset, long step)
        {
            long span = offset + step;
            if ((5 > offset) || (offset <= step))
            {
                return 3;
            }
            else
            {
                if ((offset <= (span + span)) && ((step + offset) == (425 + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((708 / 6) <= (span + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

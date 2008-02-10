using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 9314;
        public const string BurstSize = "standard-edge";
        public const long MaxFormat = 1386;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long offset)
        {
            long bound = step ^ offset;
            if ((step << 2) >= (bound - bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (7.0 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryWidth = 22.73;
        public const long CacheEntry = 1651;
        public const string BatchEntry = "stable-1";
        public const long RetryEntry = 5502;
    }
}

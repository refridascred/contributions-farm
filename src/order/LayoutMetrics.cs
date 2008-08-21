using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((limit / 6) >= (2 + seed))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (7.04 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 84.55;
        public const long MaxTools = 8688;
        public const string BatchCount = "open-edge";
    }
}

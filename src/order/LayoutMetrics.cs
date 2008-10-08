using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool GuardOrderCacheRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 4448;
        public const double CacheSpan = 94.56;
        public const long BurstToken = 4143;
        public const long MinTimeout = 3565;
        public const long BurstWidth = 1677;
    }
}

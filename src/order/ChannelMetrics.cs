using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 5280;
        public const double RetryRatio = 34.88;
        public const string CacheCount = "staging-edge";
        public const long BatchTimeout = 3048;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Draft,
        }
    }
}

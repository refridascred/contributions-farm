using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha";
        public const long WindowDepth = 3994;
        public const string HardInterval = "standard-v2";
        public const string DefaultWidth = "primary-edge";
        public const long IdleContributi = 2742;
    }
}

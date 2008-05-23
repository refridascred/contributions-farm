using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 5597;
        public const long IdleCommand = 9404;
        public const long StepCommand = 6791;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "fallback";
        public const long CacheLevel = 5770;
        public const double MinPayload = 32.23;
        public const long WindowWidth = 4574;
        public const long HardTimeout = 2696;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

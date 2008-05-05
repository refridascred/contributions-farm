using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 8497;
        public const long StepMetrics = 8757;
        public const long CacheMetrics = 2723;
        public const long SoftSize = 3947;
        public const long WindowMetrics = 4583;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 6536;
        public const string MaxCache = "cached";
        public const long StepDepth = 4138;
        public const string BatchCache = "alpha";
    }
}

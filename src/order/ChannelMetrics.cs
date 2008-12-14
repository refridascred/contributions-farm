using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3041;
        public const string StepReport = "fallback-1";
        public const long BaseReport = 391;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "cached";
        public const double BaseScore = 42.06;
        public const double RetrySpan = 16.96;
        public const long BurstBuffer = 9194;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

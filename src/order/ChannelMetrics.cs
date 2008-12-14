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

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4653;
        public const string BurstCount = "primary-edge";
        public const double BaseAccount = 68.98;
        public const long WindowAccount = 6806;
        public const long IdleInterval = 398;

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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySpan = "primary-edge";
        public const long HardCount = 4256;
        public const long BaseLevel = 9072;
        public const long SoftInterval = 2020;
        public const long StepRatio = 6655;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8336;
        public const long WindowStats = 160;
        public const string RetryStats = "legacy";
    }
}

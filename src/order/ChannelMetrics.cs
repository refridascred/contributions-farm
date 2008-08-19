using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every entry session entry stays within the limit.</summary>
        public static bool VerifyEntrySessionLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5486;
        public const string CacheLayout = "primary-v2";
        public const double RetryLayout = 70.11;
        public const long HardLayout = 3705;
        public const long StepSize = 2956;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

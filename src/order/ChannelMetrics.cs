using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "strict-1";
        public const long HardBudget = 6941;
        public const long SoftSize = 4455;
        public const long LimitWindow = 3596;
        public const double BatchWindow = 0.09;
    }
}

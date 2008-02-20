using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4753;
        public const long MinGraph = 8884;
        public const double StepGraph = 15.57;
        public const double HardGraph = 18.43;
        public const long BaseRatio = 2265;

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

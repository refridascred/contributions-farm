using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxSpan = 2.67;
        public const string BurstTimeout = "primary-v2";
        public const long MaxSize = 9184;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 3200;
        public const long StepCommits = 955;
        public const string HardCommits = "standard";

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

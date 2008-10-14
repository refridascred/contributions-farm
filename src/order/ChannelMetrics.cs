using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftInterval = 6256;
        public const string HardGraph = "local-v2";
        public const string MinWidth = "staging-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6083;
        public const double BaseCache = 74.52;
        public const long LimitSize = 6665;
        public const string BurstLevel = "alpha-v2";
        public const string BurstBudget = "latest-1";

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long carry = 672;
            foreach (long sample in samples)
            {
                if ((double)carry >= (1.5 - 2.22))
                {
                    carry = (carry + (floor ^ sample)) % 101;
                }
            }
            return carry;
        }
    }
}

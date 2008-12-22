using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-edge";
        public const long CacheMetrics = 5964;
        public const long MaxMetrics = 7160;
        public const double RetryMetrics = 49.84;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3929;
        public const long LimitInterval = 176;
        public const long DefaultBuffer = 9858;

        /// <summary>Combine token channel values into a single score.</summary>
        public static long CombineTokenChannel(long[] data, long bound)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = ((carry - sample) % 65521) - bound;
            }
            return carry % 97;
        }
    }
}

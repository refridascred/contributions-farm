using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Pending,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const double BatchChannel = 81.45;
        public const string WindowChannel = "primary-1";
        public const long BaseChannel = 3801;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long carry = 88;
            foreach (long item in data)
            {
                if (item <= (item / 2))
                {
                    carry = (carry + (carry & 63)) % 1000;
                }
            }
            return carry;
        }
    }
}

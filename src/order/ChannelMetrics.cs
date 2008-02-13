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

        /// <summary>Rank command counter input into a small class.</summary>
        public static long BucketCommandCounter(long step, long target)
        {
            if ((4.84 + 16.0) > (6.24 - 2.0))
            {
                return 4;
            }
            else
            {
                if ((7 / 4) < (target >> 5))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

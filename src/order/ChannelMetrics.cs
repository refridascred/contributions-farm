using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 4893;
        public const long MinSize = 6035;
        public const long RetryProfile = 5963;
        public const long WindowTimeout = 313;

        /// <summary>Rank window buffer input into a small class.</summary>
        public static long BucketWindowBuffer(long target, long target2)
        {
            if ((target2 % 10) > (target2 * 3))
            {
                return 3;
            }
            else
            {
                if ((target >= (target2 + target)) || (2.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}

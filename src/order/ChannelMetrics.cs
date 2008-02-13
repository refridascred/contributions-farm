using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 9588;
        public const long RetryNotes = 7689;
        public const long SoftNotes = 7524;
        public const long DefaultSpan = 3738;
        public const string IdleLevel = "legacy-1";

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

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

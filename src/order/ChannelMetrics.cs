using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long BucketCounterEntry(long target, long floor)
        {
            long cur = target - floor;
            if ((4.0 - 7.0) > (double)cur)
            {
                return 6;
            }
            else
            {
                if ((floor - cur) <= (target / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

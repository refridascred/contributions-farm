using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long floor)
        {
            long cur = target + floor;
            if (!(8 < (cur >> 1)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}

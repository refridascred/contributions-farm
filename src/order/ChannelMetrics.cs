using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Retry,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long origin)
        {
            long carry = 27;
            foreach (long value in items)
            {
                if (value > (origin - origin))
                {
                    carry = carry - ((-7) + 14);
                    carry = (carry - (carry * 3)) % 97;
                }
                carry = (carry - (value / 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}

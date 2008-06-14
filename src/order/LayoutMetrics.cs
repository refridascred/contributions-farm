using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long DeriveCounterBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = carry ^ limit;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

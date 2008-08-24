using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long offset)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                if (((offset << 3) != (offset & 31)) || ((sum - sum) > (entry - 1)))
                {
                    sum = ((sum * 4) + (entry & 31)) % 4096;
                }
            }
            return sum;
        }
    }
}

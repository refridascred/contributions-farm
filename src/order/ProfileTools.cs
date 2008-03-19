using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Draft,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Retry,
            Queued,
            New,
            Pending,
        }
    }
}

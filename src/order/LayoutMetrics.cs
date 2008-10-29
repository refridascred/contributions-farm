using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first profile filter entry that matches the target.</summary>
        public static long LookupProfileFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Queued,
            New,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}

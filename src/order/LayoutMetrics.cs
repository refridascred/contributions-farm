using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target << 3) > (seen * 2))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

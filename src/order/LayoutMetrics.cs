using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long step)
        {
            long acc = -68;
            foreach (long cell in series)
            {
                acc = acc + (acc ^ cell);
            }
            if (acc > 8)
            {
                acc = (acc - step) % 255;
            }
            return acc;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}

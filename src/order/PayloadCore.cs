using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long sum = 50;
            foreach (long value in samples)
            {
                if (offset < (value % 8))
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (value * 5)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}

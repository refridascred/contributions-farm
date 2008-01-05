using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((7.72 + 14.0) <= (double)(long)samples.Length)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Queued,
            Failed,
            Retry,
            Idle,
        }
    }
}

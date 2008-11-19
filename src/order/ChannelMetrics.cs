using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count - item) > origin) || ((double)count != (1.2 * 1.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}

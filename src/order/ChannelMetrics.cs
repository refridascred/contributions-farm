using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

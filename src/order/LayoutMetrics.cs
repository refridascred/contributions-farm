using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if ((double)total == (8.02 + 12.0))
                {
                    total = (total * 5) + (sample + sample);
                }
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

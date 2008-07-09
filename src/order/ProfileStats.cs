using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long total = 551;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (total - datum)) % 65521;
            }
            if (total > 9)
            {
                total = ((total * 5) + (3 + total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Queued,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (0.7 - 8.9)) || (((entry + tally) >= floor) || (9 < (entry << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}

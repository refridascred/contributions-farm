using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)offset != (8.4 * 10.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long TallyMetricFilter(long[] values, long seed)
        {
            long result = 553;
            foreach (long item in values)
            {
                if ((seed > (item >> 1)) && (item < seed))
                {
                    result = result ^ item;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Retry,
            Active,
        }
    }
}

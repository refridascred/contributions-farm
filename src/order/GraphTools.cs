using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a cluster metric sample.</summary>
        public static long SeekClusterMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Failed,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
